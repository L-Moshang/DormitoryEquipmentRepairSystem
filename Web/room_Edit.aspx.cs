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

public partial class room_Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"];
            Bll.room br = new Bll.room();
            DataSet ds = br.GetroomList("id="+id);
            louhao.Text = ds.Tables[0].Rows[0]["louhao"].ToString();
            loucheng.Text = ds.Tables[0].Rows[0]["loucheng"].ToString();
            person.Text = ds.Tables[0].Rows[0]["person"].ToString();
            roomno.Text = ds.Tables[0].Rows[0]["roomno"].ToString();
            telphone.Text = ds.Tables[0].Rows[0]["telphone"].ToString();
            weisheng.Text = ds.Tables[0].Rows[0]["weisheng"].ToString();
            if (ds.Tables[0].Rows[0]["jilu"].ToString().Trim() == "有")
            {
                r1.Checked = true;
            }
            else
            {
                r2.Checked = true;
            }
        }
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
        room.id = Request.QueryString["id"];
        room.telphone = telphone.Text.Trim();
        Bll.room br = new Bll.room();
        if (br.roomUpdate(room) == 1)
        {
            MessageBox.ShowUrl(Page, this, "修改成功", "room_Admin.aspx");
        }
    }
}
