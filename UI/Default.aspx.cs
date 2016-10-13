using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable dt = BLL.Login.check("select * from quanxian");
        if (dt.Rows.Count==1)
        {
            Session["userName"] = TextBox1.Text;
            Session["qx"] = TextBox3.Text;
            Response.Redirect("Default2.aspx");
        }
        else
        {
            Label4.Text = "用户名或者密码错误";
        }
    }

}