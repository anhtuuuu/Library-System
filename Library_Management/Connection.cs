using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library_Management
{
    internal class Connection
    {
        private static string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Learn\C#\Library_System\Library_Management\LibraryDB.mdf;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(_connectionString);
        }  
    }
}
