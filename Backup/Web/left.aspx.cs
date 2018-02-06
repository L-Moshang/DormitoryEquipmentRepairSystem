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

public partial class admin_left : System.Web.UI.Page
{
    public string admin = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        
        if (Session["admin"] == null)
        {
            Response.Write("<script>");
            Response.Write("top.location.href ='login.aspx';");
            Response.Write("</script>");
        }

        string power = (string)Session["power"];
        string stext = "";
        if (power == "2")
        {
            P1.Visible = true;
            P2.Visible = false;
            stext = "管理员：";
        }
        else
        {
            P1.Visible = false;
            P2.Visible = true;
            stext = "学生：";
        }

        admin = stext+(string)Session["admin"];
    }
}
