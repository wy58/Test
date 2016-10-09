using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
     public  class DBHelper
    {
         public static DataTable getdt(string strSQL)
         {
             string strConn = "data source=.;initial catalog=t;integrated security=true";
             SqlConnection conn = new SqlConnection(strConn);
             conn.Open();
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
             da.Fill(dt);
             conn.Close();
             return dt;
         }
    }
}
