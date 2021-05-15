using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Text;
using Gestion_Patrimoine.Dto;
using Gestion_Patrimoine.Db;

namespace Gestion_Patrimoine.Repositories
{
    public class CategoryRepository
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;
        Command mCommand;

        public CategoryRepository()
        {
            provider = Config.Provider;
            connectionString = Config.ConnectionString;
            factory = DbProviderFactories.GetFactory(provider);
            mCommand = new Command();
        }

        public List<CategoryDto> categories()
        {
            List<CategoryDto> categories = new List<CategoryDto>();
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"select * from categories";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(
                            new CategoryDto 
                            { 
                                Id = Int16.Parse(reader["id"].ToString()), 
                                Nom = reader["nom"].ToString() 
                            }
                         );
                    }
                }
            }
            return categories;
        }

        public CategoryDto findById(int id)
        {
            CategoryDto categoryDto = new CategoryDto();
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"select * from categories where id = {id}";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categoryDto.Id = Int16.Parse(reader["id"].ToString());
                        categoryDto.Nom = reader["nom"].ToString();
                    }
                }
            }
            return categoryDto;
        }

        public CategoryDto save(CategoryDto category)
        {
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"insert into categories values ('{category.Nom}')";
                command.ExecuteNonQuery();
            }
            return category;
        }

        public void delete(int id)
        {
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"delete from categories where id = {id})";
                command.ExecuteNonQuery();
            }
        }

    }
}
