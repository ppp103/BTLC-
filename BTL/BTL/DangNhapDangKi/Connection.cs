using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BTL.DangNhapDangKi
{
    internal class Connection
    {
        private static string stringconnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Dell Mediamart\\Source\\Repos\\ppp103\\BTLC-\\BTL\\BTL\\DangNhapDangKi\\DangNhap.mdf\";Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringconnection);
        }
    }
}
