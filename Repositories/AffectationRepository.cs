using Gestion_Patrimoine.Db;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Text;
using Gestion_Patrimoine.Repositories;
using Gestion_Patrimoine.Dto;
using Gestion_Patrimoine.Db;

namespace Gestion_Patrimoine.Repositories
{
    public class AffectationRepository
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;
        Command mCommand;
        UserRepository userRepository;
        PatrimoineRepository patrimoineRepository;

        public AffectationRepository()
        {
            provider = Config.Provider;
            connectionString = Config.ConnectionString;
            factory = DbProviderFactories.GetFactory(provider);
            mCommand = new Command();
            userRepository = new UserRepository();
            patrimoineRepository = new PatrimoineRepository();
        }

        public List<Demande> getAll()
        {
            List<Demande> demandes = new List<Demande>();
            
            using(DbConnection connection = factory.CreateConnection())
            {
                DbCommand command = mCommand.GetCommand(connection);
                command.CommandText = "select * from demandes where status = 'denied'";
                using(DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Demande demande = new Demande();
                        int patrimoinId = Int16.Parse(reader["patrimoine_id"].ToString());
                        int employeeId = Int16.Parse(reader["utilisateur_id"].ToString());
                        int demandeId = Int16.Parse(reader["id"].ToString());
                        UserDto user = userRepository.findById(employeeId);
                        PatrimoineDto patrimoine = patrimoineRepository.findById(patrimoinId);
                        string fullName = user.FirstName + " " + user.LastName;
                        string patNom = patrimoine.Nom; 
                        demande.DemandeId = demandeId;
                        demande.FullName = fullName;
                        demande.PatNom = patNom;
                        demandes.Add(demande);
                    }
                }
            }
            return demandes;
        }

        public void demandeAffectation(int patrimoineId, int employeeId)
        {
            using(var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"insert into demandes values ({patrimoineId}, {employeeId}, 'denied')";
                command.ExecuteNonQuery();
            }
        }

        /*public void acceptDemande(int patrimoineId, int employeeId)
        {
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"update demande set status = 'granted'";
                command.ExecuteNonQuery();
            }
        }*/

        public void acceptDemande(int demandeId)
        {
            int patrimoineId = 0;
            int utilisateurId = 0;
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"select * from demandes where id = {demandeId}";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patrimoineId = Int16.Parse(reader["patrimoine_id"].ToString());
                        utilisateurId = Int16.Parse(reader["utilisateur_id"].ToString());
                    }
                }

                command.CommandText = $"update patrimoines set idEmployee={utilisateurId} where id={patrimoineId}";
                command.ExecuteNonQuery();

                command.CommandText = $"delete from demandes where id={demandeId}";
                command.ExecuteNonQuery();
            }
        }

        public void removeDemande(int id)
        {
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"delete from demande where id = {id}";
                command.ExecuteNonQuery();
            }
        }

        public void affecter(int patrimoineId, int employeeId)
        {
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"update patrimoines set idEmployee={employeeId} where id={patrimoineId}";
                command.ExecuteNonQuery();
            }
        }
    }
}
