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

public partial class admin_delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string power = (string)Session["power"];
        if (power == "2")
        {
            Response.Redirect("power.aspx");
        }
        else
        {
            string id = Request.QueryString["id"];
            Bll.admin ba = new Bll.admin();
            ba.Deleteadmin(int.Parse(id));
            MessageBox.ShowUrl(Page, this, "删除成功", "admin_Admin.aspx");
        }
    }
}
