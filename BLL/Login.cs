using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
     public  class Login
    {
         public static int l(string usename, string upassword)
         {
             string strSQL = "select * from DL where Usename='" + usename + "'";
             DataTable dt = DBHelper.getdt(strSQL);
             if (dt.Rows.Count == 0)
             {
                 return 0;
             }
             else
             {
                 if (dt.Rows[0]["Password"].ToString() == upassword)
                 {
                     return 1;
                 }
                 else
                 {
                     return 2;
                 }
             }
         }
    }
}
