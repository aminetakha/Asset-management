using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Patrimoine.Db
{
    public static class Config
    {
        public static string Provider { get; } = "System.Data.SqlClient";
        public static string ConnectionString { get; } = "Data Source=DESKTOP-ORMGBN3;Initial Catalog=Gestion_Patrimoine;Integrated Security=True";
    }
}
