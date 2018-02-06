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

public partial class shebie_delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id=Request.QueryString["id"];
        Bll.shebie bs = new Bll.shebie();
        bs.Deleteshebie(int.Parse(id));
        MessageBox.ShowUrl(Page,this,"删除成功","shebie_admin.aspx");
    }
}
