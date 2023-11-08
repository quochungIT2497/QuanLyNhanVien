using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BaiTapWinForm
{
    internal class Modify
    {
        SqlDataAdapter adapter;
        SqlCommand cmd;

        public Modify()
        {
        }

        public DataTable DT(string query)
        {
            DataTable dt = new DataTable();
            using(SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public void Command(string query)
        {
            using(SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
