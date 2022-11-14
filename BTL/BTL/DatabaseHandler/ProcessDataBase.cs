using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class ProcessDataBase
    {
        static string strConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\STEP\source\repos\BTLC--main\BTLC--main\BTL\BTL\DataBase\SanPham.mdf;Integrated Security=True";
        static SqlConnection sqlketnoi = null;
        private SqlCommand sqlCommand;
        static private void KetNoiCSDL()
        {
            sqlketnoi = new SqlConnection(strConnect);
            if (sqlketnoi.State != ConnectionState.Open)
                sqlketnoi.Open();

        }
        static private void DongCSDL()
        {
            if (sqlketnoi.State != ConnectionState.Closed)
            {
                sqlketnoi.Close();
            }
            sqlketnoi.Dispose();//giai phong bo nho
        }
        static public DataTable ReadTable(string sql)
        {
            DataTable dt = new DataTable();
            KetNoiCSDL();
            SqlDataAdapter adt = new SqlDataAdapter(sql, sqlketnoi);
            adt.Fill(dt);
            DongCSDL();
            return dt;
        }
        static public void UpdateData(string sql)
        {
            KetNoiCSDL();
            SqlCommand sm = new SqlCommand();
            sm.Connection = sqlketnoi;
            sm.CommandText = sql;
            sm.ExecuteNonQuery();
            DongCSDL();
        }
        public void Excute(string query)
        {
            using (SqlConnection sqlConnection = new SqlConnection(strConnect))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
