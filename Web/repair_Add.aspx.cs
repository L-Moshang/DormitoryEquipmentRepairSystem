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

public partial class repair_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Bll.shebie types = new Bll.shebie();
        DataSet dss = types.GetshebieList("");
        for (int i = 0; i < dss.Tables[0].Rows.Count; i++)
        {
            ListItem li = new ListItem();
            li.Value = dss.Tables[0].Rows[i]["id"].ToString();
            li.Text = dss.Tables[0].Rows[i]["wname"].ToString();
            name.Items.Add(li);
        }
        stuno.Text = Session["admin"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Model.repair re = new Model.repair();
        re.madetime = madetime.Text.Trim();
        re.name = name.Text.Trim();
        re.reason = reason.Text.Trim();
        re.roomno = roomno.Text.Trim();
        re.sname = sname.Text.Trim();
        re.stuno = stuno.Text.Trim();
        Bll.repair br = new Bll.repair();
        if (br.repairAdd(re) == 1)
        {
            MessageBox.ShowUrl(Page,this,"添加成功","repair_Add.aspx");
        }
    }
}
