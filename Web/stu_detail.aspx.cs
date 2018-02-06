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

public partial class stu_detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string sno = Request.QueryString["sno"];
        string sname = Request.QueryString["sname"];
        Bll.student bs = new Bll.student();
        DataSet ds ;
        if (!string.IsNullOrEmpty(sno))
        {
            ds = bs.GetstudentList("stuno='" + sno + "'");
        }
        else
        {
            ds = bs.GetstudentList("name='" + sname + "'");
        }
        name.Text = ds.Tables[0].Rows[0]["name"].ToString();
        intime.Text = ds.Tables[0].Rows[0]["intime"].ToString();
        outtime.Text = ds.Tables[0].Rows[0]["outtime"].ToString();
        roomno.Text = ds.Tables[0].Rows[0]["roomno"].ToString();
        teaphone.Text = ds.Tables[0].Rows[0]["teaphone"].ToString();
        stuphone.Text = ds.Tables[0].Rows[0]["stuphone"].ToString();
        stuno.Text = ds.Tables[0].Rows[0]["stuno"].ToString();
        bedno.Text = ds.Tables[0].Rows[0]["bedno"].ToString();
        zhuanye.Text = ds.Tables[0].Rows[0]["zhuanye"].ToString();
        sex.Text = ds.Tables[0].Rows[0]["sex"].ToString();
    }
}
