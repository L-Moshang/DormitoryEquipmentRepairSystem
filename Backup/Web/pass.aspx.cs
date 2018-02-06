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

public partial class pass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (pass2.Text.Trim() == pass3.Text.Trim())
        {
            string username = (string)Session["admin"];
            string sql = "update users set pass='"+pass3.Text.Trim()+"' where sn='"+username+"'";
            if (Dal.DbHelperSQL.ExecuteSql(sql) == 1)
            {
                MessageBox.ShowUrl(Page, this, "密码修改成功", "pass.aspx");
            }
        }
        else
        {
            MessageBox.ShowUrl(Page,this,"确认密码和新密码不一样","pass.aspx");
        }
    }
}
