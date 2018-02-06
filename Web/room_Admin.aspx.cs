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

public partial class room_Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            dataBind();
        }

    }
    public void dataBind()
    {
        string sql;
        string keyword = Request.QueryString["key"];
        if (!string.IsNullOrEmpty(keyword))
        {
            sql = "select * from room  where roomno='"+keyword+"' order by id desc";
        }
        else
        {
            sql = "select * from room  order by id desc";
        }
        GridView1.DataSource = Dal.DbHelperSQL.Query(sql);
        GridView1.DataKeyNames = new string[] { "id" };
        GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        dataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("room_Admin.aspx?key="+key.Text.Trim());
    }
}
