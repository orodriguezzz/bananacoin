using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananacoindotNet.BL.dapper
{
    public static class config
    {
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["providerConnection"].ConnectionString;

        public static DbConnection GetOpenConnection()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
