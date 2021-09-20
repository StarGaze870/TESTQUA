using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_JunkShop
{
    class ConnectDB
    {
        public static SqlConnection connection;
        public static string sourceString = $"Data Source={Environment.MachineName};Initial Catalog=E-JunkShop;Integrated Security=True";

        public static void connect()
        {
            try
            {
                connection = new SqlConnection(sourceString);
                connection.Open();
            }
            catch
            {
                // CREATE DATABASE AND TABLES IF NOT EXIST YET
                
                
            }            
        }
    }
}
