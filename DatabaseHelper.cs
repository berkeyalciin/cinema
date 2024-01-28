using System;
using System.Data.SqlClient;

namespace cinema1
{
    public static class DatabaseHelper
    {
        private static readonly string ConnectionString = "Data Source=LAPTOP-LE9FBROO\\MSSQLSERVER01;Initial Catalog=cinema_db;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
