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

public partial class student_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
        stu.zhuanye = zhuanye.Text.Trim();
        stu.pass = stuno.Text.Trim();
        Bll.student bs = new Bll.student();
        if (bs.studentAdd(stu) == 1)
        {
            MessageBox.ShowUrl(Page,this,"添加成功","student_Add.aspx");
        }
    }
}
