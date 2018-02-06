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

public partial class student_delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        Bll.student bs = new Bll.student();
        bs.Deletestudent(int.Parse(id));
        MessageBox.ShowUrl(Page,this,"删除成功","student_Admin.aspx");
    }
}
