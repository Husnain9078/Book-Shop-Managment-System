using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CRUD
{
    class Configuration
    {
        String connectionString = @"Data Source=DESKTOP-46RIC5P\MSSQLSERVER01;Initial Catalog=Book;Integrated Security=True";
        SqlConnection con;
        private static Configuration _instance;
        public static Configuration getInstance()
        {
            if (_instance == null)
                _instance = new Configuration();
            return _instance;
        }
        private Configuration()
        {
            con = new SqlConnection(connectionString);
            con.Open();
            
        }
        public SqlConnection getConnection()
        {
            return con;
        }
    }
}






