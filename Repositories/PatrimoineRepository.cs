using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Text;
using Gestion_Patrimoine.Dto;
using Gestion_Patrimoine.Db;

namespace Gestion_Patrimoine.Repositories
{
    public class PatrimoineRepository
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;
        CategoryRepository categoryRepository;
        CategoryDto category;
        List<PatrimoineDto> patrimoines;
        Command mCommand;

        public PatrimoineRepository()
        {
            provider = Config.Provider;
            connectionString = Config.ConnectionString;
            factory = DbProviderFactories.GetFactory(provider);
            categoryRepository = new CategoryRepository();
            mCommand = new Command();
            patrimoines = new List<PatrimoineDto>();
        }

        public void populatePatrimoines(DbDataReader reader)
        {
            
            int categoryId = Int16.Parse(reader["idCategory"].ToString());
            category = categoryRepository.findById(categoryId);
            patrimoines.Add(
                new PatrimoineDto
                {
                    Id = Int16.Parse(reader["id"].ToString()),
                    Nom = reader["nom"].ToString(),
                    Description = reader["description"].ToString(),
                    DateAchat = reader["dateAchat"].ToString(),
                    Prix = Double.Parse(reader["prix"].ToString()),
                    DureeAmortissement = Int16.Parse(reader["dureeAmortissement"].ToString()),
                    TauxAmortissement = Int16.Parse(reader["tauxAmortissement"].ToString()),
                    PrixAmortissement = Double.Parse(reader["prixAmortissement"].ToString()),
                    Anciennte = Int16.Parse(reader["anciennte"].ToString()),
                    Status = reader["status"].ToString(),
                    Category = category
                }
            );
        }

        public List<PatrimoineDto> GetAll()
        {
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = "select * from patrimoines";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        populatePatrimoines(reader);
                    }
                }
            }
            return patrimoines;
        }

        public List<PatrimoineDto> GetAll(int employeeId)
        {
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"select * from patrimoines where employeeId = {employeeId}";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        populatePatrimoines(reader);
                    }
                }
            }
            return patrimoines;
        }

        public PatrimoineDto findById(int id)
        {
            PatrimoineDto patrimoine = new PatrimoineDto();
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"select * from patrimoines where id = {id}";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patrimoine.Nom = reader["nom"].ToString();
                    }
                }
            }
            return patrimoine;
        }

        public PatrimoineDto save(PatrimoineDto patrimoine)
        {
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"insert into patrimoines values ('{patrimoine.Nom}', '{patrimoine.Description}', " +
                    $"'{patrimoine.DateAchat}', {patrimoine.Prix}, {patrimoine.DureeAmortissement}, {patrimoine.TauxAmortissement}," +
                    $"{patrimoine.PrixAmortissement}, {patrimoine.Anciennte}, '{patrimoine.Status}', {patrimoine.Category.Id}";
                command.ExecuteNonQuery();
            }
            return patrimoine;
        }

        public void delete(int id)
        {
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"delete from patrimoines where id = {id}";
                command.ExecuteNonQuery();
            }
        }

        public void update(PatrimoineDto patrimoine)
        {
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"update patrimoines set nom='{patrimoine.Nom}', description='{patrimoine.Description}', " +
                    $"dateAchat='{patrimoine.DateAchat}', prix={patrimoine.Prix}, dureeAmortissement={patrimoine.DureeAmortissement}, tauxAmortissement={patrimoine.TauxAmortissement}," +
                    $"prixAmortissement={patrimoine.PrixAmortissement}, anciennte={patrimoine.Anciennte}, status='{patrimoine.Status}'";
                command.ExecuteNonQuery();
            }
        }
    }
}
