using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class shebie_edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"];
            Bll.shebie br = new Bll.shebie();
            DataSet ds = br.GetshebieList("id=" + id);
            this.wname.Text = ds.Tables[0].Rows[0]["wname"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = "update shebie set wname='" + wname.Text.Trim() + "'  where id=" + Request.QueryString["id"];
        if (Dal.DbHelperSQL.ExecuteSql(sql) == 1)
        {
            MessageBox.ShowUrl(Page, this, "回复成功", "shebie_admin.aspx");
        }
    }
}