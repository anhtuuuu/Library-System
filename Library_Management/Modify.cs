using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library_Management
{
    internal class Modify
    {
        public Modify() { }
        SqlCommand sqlCommand;
        SqlDataReader reader;
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(reader.GetString(4), reader.GetString(5)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }
    }
}
