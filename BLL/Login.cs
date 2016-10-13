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
        public static int check(string name, string password)
        {
            string strSQL = "select * from w where username='" + name + "'";
            DataTable dt = DBHelper.getdt(strSQL);
            if (dt.Rows.Count == 0)
            {
                return 1;
            }
            else
            {
                if (dt.Rows[0]["userpa"].ToString() == password)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
