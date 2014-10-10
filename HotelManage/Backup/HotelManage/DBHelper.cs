using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace HotelManage
{
    public class DBHelper
    {
        private static SqlConnection con;
        public static SqlConnection Con
        {
            get
            {
                string constr = "server=.;database=HotelManage;uid=sa;pwd=sa";
                if (con == null)
                {
                    con = new SqlConnection(constr);
                    con.Open();
                }
                else if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                else if (con.State == System.Data.ConnectionState.Broken)
                {
                    con.Close();
                    con.Open();
                }
                return con;
            }
        }
        public static DataTable GetTable(string sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(ds);
            return ds.Tables[0];
        }
        public static int SqlDelete(string sqlstr)
        {
            SqlCommand com = new SqlCommand(sqlstr, con);
            int result = com.ExecuteNonQuery();
            return result;
        }
    }
}