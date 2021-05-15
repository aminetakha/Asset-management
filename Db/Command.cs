using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Gestion_Patrimoine.Db;

namespace Gestion_Patrimoine.Db
{
    public class Command
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public Command()
        {
            provider = Config.Provider;        
            connectionString = Config.ConnectionString;
            factory = DbProviderFactories.GetFactory(provider);
        }

        public DbCommand GetCommand(DbConnection connection)
        {
            connection.ConnectionString = connectionString;
            connection.Open();
            var command = connection.CreateCommand();
            command.Connection = connection;
            return command;
        }
    }
}
