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

public partial class admin_Admin : System.Web.UI.Page
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

        string sql = "select * from admin  order  by id desc";
        GridView1.DataSource = Dal.DbHelperSQL.Query(sql);
        GridView1.DataKeyNames = new string[] { "id" };
        GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        dataBind();
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{

        //    string power = e.Row.Cells[3].Text.ToString();
        //    string s = "普通管理员";
        //    int n = int.Parse(power);
        //    if (n == 1)
        //    {
        //        s = "超级管理员";
        //    }
        //    e.Row.Cells[3].Text = s;
        //}

    }
}
