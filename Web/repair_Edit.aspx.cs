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

public partial class repair_Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"];
            Bll.repair br = new Bll.repair();
            DataSet ds = br.GetrepairList("id="+id);
            reply.Text = ds.Tables[0].Rows[0]["reply"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = "update repair set reply='"+reply.Text.Trim()+"' ,replytime='"+DateTime.Now.ToString("d")+"' where id="+Request.QueryString["id"];
        if (Dal.DbHelperSQL.ExecuteSql(sql) == 1)
        {
            MessageBox.ShowUrl(Page, this, "回复成功", "repair_Admin.aspx");
        }
    }
}
