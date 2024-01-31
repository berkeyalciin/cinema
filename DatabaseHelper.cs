using System;
using System.Data.SqlClient;

namespace cinema1
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private string connectionString;
        private SqlConnection connection;

        private DatabaseConnection()
        {
            // Veritabanı bağlantı dizesini burada tanımlayın.
            connectionString = "Data Source=LAPTOP-LE9FBROO\\MSSQLSERVER01;Initial Catalog=cinema_db;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseConnection();
                }
                return _instance;
            }
        }

        public SqlConnection Connection
        {
            get { return connection; }
        }
    }

}