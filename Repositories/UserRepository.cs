using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Text;
using Gestion_Patrimoine.Dto;
using System.Data.SqlClient;
using Gestion_Patrimoine.Db;

namespace Gestion_Patrimoine.Repositories
{
    public class UserRepository
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;
        Command mCommand;

        public UserRepository()
        {
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            provider = Config.Provider;
            connectionString = Config.ConnectionString;
            factory = DbProviderFactories.GetFactory(provider);
            mCommand = new Command();
        }

        public UserLoginResponseDto findUser(UserLoginDto userLoginDto, string type)
        {
            string email = userLoginDto.Email;
            string password = userLoginDto.Password;
            int id;
            UserDto user = null;
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"select * from compte where username = '{email}' and password = '{password}' and type='{type}'";
                using(DbDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        UserLoginResponseDto response = new UserLoginResponseDto(false, null);
                        return response;
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            id = Int16.Parse(reader["id"].ToString());
                            user = findUserById(id);
                        }
                        return new UserLoginResponseDto(true, user);
                    }
                }
            } 
        }

        public UserDto findById(int id)
        {
            UserDto userDto = new UserDto();
            using(var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"select * from utilisateurs where id = {id}";
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userDto.FirstName = reader["first_name"].ToString();
                        userDto.LastName = reader["last_name"].ToString();
                        userDto.Age = Int16.Parse(reader["age"].ToString());
                    }
                }
            }
            return userDto;
        }

        public UserDto findUserById(int id)
        {
            UserDto user = new UserDto();
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"select * from utilisateurs where idCompte = {id}";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idCompte = Int16.Parse(reader["idCompte"].ToString());
                        string firstName = reader["first_name"].ToString().Trim();
                        string lastName = reader["last_name"].ToString().Trim();
                        int age = Int16.Parse(reader["age"].ToString());
                        
                        user.Id = idCompte;
                        user.FirstName = firstName;
                        user.LastName = lastName;
                        user.Age = age;
                    }
                }
            }
            return user;
        }

        public List<UserDto> getAll()
        {
            List<UserDto> users = new List<UserDto>();
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = "select * from utilisateurs";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Int16.Parse(reader["idCompte"].ToString());
                        string firstName = reader["first_name"].ToString().Trim();
                        string lastName = reader["last_name"].ToString().Trim();
                        int age = Int16.Parse(reader["age"].ToString());
                        UserDto user = new UserDto();
                        user.Id = id;
                        user.FirstName = firstName;
                        user.LastName = lastName;
                        user.Age = age;
                        users.Add(user);
                    }
                }

            }
            return users;
        }

        public void save(string email, string password, string firstName, string lastName, int age)
        {
            int id = 0;
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"insert into compte (username, password, type) values" +
                    $" ('{email}', '{password}', 'employee') " +
                    "SELECT CAST(scope_identity() AS int)";
                id = (Int32)command.ExecuteScalar();

                command.CommandText = "insert into utilisateurs (first_name, last_name, age, idCompte) values " +
                    $"('{firstName}', '{lastName}', {age}, {id})";
                command.ExecuteNonQuery();
            }
        }

        public void update(UserDto user)
        {
            using (var connection = factory.CreateConnection())
            {
                var command = mCommand.GetCommand(connection);
                command.CommandText = $"update utilisateurs set first_name='{user.FirstName}', last_name='{user.LastName}', age={user.Age} where idCompte={user.Id}";
                command.ExecuteNonQuery();
            }
        }
    }
}
