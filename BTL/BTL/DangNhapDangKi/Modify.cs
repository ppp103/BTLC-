using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BTL.DangNhapDangKi
{
    internal class Modify
    {
        public Modify()
        {

        }
        SqlCommand sqlCommand;
        SqlDataReader DataReader;
        public List<Id> Id(string query)
        {
            List<Id> ids = new List<Id>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                DataReader =sqlCommand.ExecuteReader();
                while (DataReader.Read())
                {
                       ids.Add(new Id(DataReader.GetString(0),DataReader.GetString(1)));

                }
                sqlConnection.Close();
            }
                return ids;
        }
        public void Command(string query)
        {
            using(SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }    
        }

    }
}
