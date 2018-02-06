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

public partial class room_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Model.room room = new Model.room();
        room.louhao = louhao.Text.Trim();
        room.loucheng = loucheng.Text.Trim();
        room.person = person.Text.Trim();
        room.roomno = roomno.Text.Trim();
        room.jilu = r1.Checked ? "有" : "无";
        room.weisheng = weisheng.Text.Trim();
        room.telphone = telphone.Text.Trim();
        Bll.room br = new Bll.room();
        if (br.roomAdd(room) == 1)
        {
            MessageBox.ShowUrl(Page,this,"添加成功","room_Add.aspx");
        }
    }
}
