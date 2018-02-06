using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class password : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (pass.Text.Trim() != pass2.Text.Trim())
        {
            MessageBox.ShowUrl(Page, this, "对不起！！！两次密码不相等", "password.aspx");
        }
        else
        {
            string sname = Session["admin"].ToString();
            string sql = "update student set pass='" + pass.Text.Trim() + "' where stuno='"+sname+"'";
            if (Dal.DbHelperSQL.ExecuteSql(sql) == 1)
            {
                MessageBox.ShowUrl(Page, this, "修改密码", "password.aspx");
            }
        }
    }
}
