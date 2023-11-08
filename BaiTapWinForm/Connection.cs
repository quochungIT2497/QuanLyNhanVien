using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BaiTapWinForm
{
    internal class Connection
    {
        private static string StrConnection = "Data Source=DESKTOP-6HJIUMS;Initial Catalog=QuanLyNhanVien;Integrated Security=True;";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(StrConnection);
        }

    }
}
