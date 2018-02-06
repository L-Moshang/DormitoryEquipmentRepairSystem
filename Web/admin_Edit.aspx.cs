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

public partial class admin_Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string power = (string)Session["power"];
        if (power == "1")
        {
            Response.Redirect("power.aspx");
        }
       
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"];
            Bll.admin ba = new Bll.admin();
            DataSet ds = ba.GetadminList("id="+id);
            username.Text = ds.Tables[0].Rows[0]["username"].ToString();
            password.Text = ds.Tables[0].Rows[0]["password"].ToString();
          
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Model.admin admin = new Model.admin();
        admin.username = username.Text.Trim();
        admin.password = password.Text.Trim();
       // admin.power = h1.Checked ? "1" : "2";
        admin.id = Request.QueryString["id"];
        Bll.admin ba = new Bll.admin();
        if (ba.adminUpdate(admin) == 1)
        {
            MessageBox.ShowUrl(Page, this, "修改成功", "admin_Admin.aspx");
        }
    }
}
