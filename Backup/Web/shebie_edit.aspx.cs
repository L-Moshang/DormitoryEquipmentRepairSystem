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

public partial class shebie_edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
           string id=Request.QueryString["id"];
           Bll.shebie bs = new Bll.shebie();
           DataSet ds = bs.GetshebieList("id="+id);
           wname.Text = ds.Tables[0].Rows[0]["wname"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Model.shebie m = new Model.shebie();
        m.wname = wname.Text.Trim();
        m.id=Request.QueryString["id"];
        Bll.shebie b = new Bll.shebie();
        if (b.shebieAdd(m) == 1)
        {
            MessageBox.ShowUrl(Page, this, "修改成功", "shebie_admin.aspx");
        }
    }
}
