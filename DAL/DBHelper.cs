using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DBHelper
    {
        public static DataTable getdt(string strSQL)
        {
            string strCon = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
