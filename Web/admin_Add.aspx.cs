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

public partial class admin_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Model.admin admin = new Model.admin();
        admin.username = username.Text.Trim();
        admin.password = password.Text.Trim();
       // admin.power = h1.Checked ? "1" : "2";
        Bll.admin ba = new Bll.admin();
        if (ba.adminAdd(admin) == 1)
        {
            MessageBox.ShowUrl(Page,this,"录入成功","admin_Add.aspx");
        }
    }
}
