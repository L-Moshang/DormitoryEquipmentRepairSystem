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

public partial class shebie_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Model.shebie m = new Model.shebie();
        m.wname = wname.Text.Trim();
        Bll.shebie b = new Bll.shebie();
        if (b.shebieAdd(m) == 1)
        {
            MessageBox.ShowUrl(Page,this,"添加成功","shebie_add.aspx");
        }
    }
}
