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
using System.Data.SqlClient;
public partial class images_login : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (power.Text.Trim() == "2")
        {
            string sql = "select * from admin where username='" + username.Text.Trim() + "' and password='" + password.Text.Trim() + "'";
            DataSet ds = Dal.DbHelperSQL.Query(sql);
            if (ds.Tables[0].Rows.Count != 0)
            {
                Session["admin"] = username.Text.Trim();
                Session["power"] = "2";
                MessageBox.ShowUrl(Page, this, "登陆成功", "main.aspx");
            }
            else
            {
                MessageBox.ShowUrl(Page, this, "用户名或者密码错误", "login.aspx");
            }
        }
        else if (power.Text.Trim() == "1")
        {
            string sql = "select * from student where stuno='" + username.Text.Trim() + "' and pass='" + password.Text.Trim() + "'";
            DataSet ds = Dal.DbHelperSQL.Query(sql);
            if (ds.Tables[0].Rows.Count != 0)
            {
                Session["admin"] = username.Text.Trim();
                Session["power"] = "1";
                MessageBox.ShowUrl(Page, this, "登陆成功", "main.aspx");
            }
            else
            {
                MessageBox.ShowUrl(Page, this, "用户名或者密码错误", "login.aspx");
            }
        }
      
    }
}

