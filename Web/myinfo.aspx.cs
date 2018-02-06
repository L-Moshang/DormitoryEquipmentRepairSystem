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

public partial class myinfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string sname=Session["admin"].ToString();
            Bll.student bs = new Bll.student();
            DataSet ds = bs.GetstudentList("stuno='"+sname+"'");
            name.Text = ds.Tables[0].Rows[0]["name"].ToString();
            intime.Text = ds.Tables[0].Rows[0]["intime"].ToString();
            roomno.Text = ds.Tables[0].Rows[0]["roomno"].ToString();
            stuphone.Text = ds.Tables[0].Rows[0]["stuphone"].ToString();
            stuno.Text = ds.Tables[0].Rows[0]["stuno"].ToString();
            bedno.Text = ds.Tables[0].Rows[0]["bedno"].ToString();
            ids.Text = ds.Tables[0].Rows[0]["id"].ToString();
            zhuanye.Text = ds.Tables[0].Rows[0]["zhuanye"].ToString();
            if (ds.Tables[0].Rows[0]["sex"].ToString().Trim() == "男")
            {
                r2.Checked = true;


            }
            else
            {
                r1.Checked = true;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Model.student stu = new Model.student();
        stu.intime = intime.Text.Trim();
        stu.roomno = roomno.Text.Trim();
        stu.sex = r1.Checked ? "女" : "男";
        stu.stuphone = stuphone.Text.Trim();
        stu.stuno = stuno.Text.Trim();
        stu.name = name.Text.Trim();
        stu.bedno = bedno.Text.Trim();
        stu.id =ids.Text.Trim();
        stu.zhuanye = zhuanye.Text.Trim();
        Bll.student bs = new Bll.student();
        if (bs.studentUpate(stu) == 1)
        {
            MessageBox.ShowUrl(Page, this, "修改成功", "myinfo.aspx");
        }
    }
}
