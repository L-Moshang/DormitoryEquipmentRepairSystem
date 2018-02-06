using System;
using System.Web.UI;
using System.Text;

/// <summary>
/// MessageBox 的摘要说明。
/// </summary>
public static class MessageBox
{
   

    #region 消息提示 调用方法:  MessageBox.Show()
    /// <summary>
    /// 消息提示
    /// 调用方法:  MessageBox.Show(Page, this, "是否可以呢!");
    /// </summary>
    /// <param name="page0">参数:Page </param>
    /// <param name="this0">参数:this </param>
    /// <param name="str">参数:显示文本内容 </param>
    public static void Show(Page page0,Page this0, string str)
    {
        StringBuilder sb = new StringBuilder("");
        sb.Append("alert('" + str + "');");
        ClientScriptManager cs = page0.ClientScript;
        if (!cs.IsStartupScriptRegistered(this0.GetType(), "Show"))
        {
            cs.RegisterStartupScript(this0.GetType(), "Show", sb.ToString(), true);
        }
    }
    

    #endregion

    #region 打开新页面 调用方法: MessageBox.OpenUrl()
    /// <summary>
    /// 打开新页面
    /// </summary>
    /// <param name="page0">参数:Page</param>
    /// <param name="this0">参数:this</param>
    /// <param name="url">参数:新页面地址</param>
    /// <param name="target">打开页面的方式</param>
    public static void OpenUrl(Page page0, Page this0, string url,int width,int height)
    {
        StringBuilder sb = new StringBuilder("");
        sb.Append("window.open('" + url + "','','width=" + width + "px','height=" + height + "px','toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no');");
        ClientScriptManager cs = page0.ClientScript;
        if (!cs.IsStartupScriptRegistered(this0.GetType(), "OpenUrl"))
        {
            cs.RegisterStartupScript(this0.GetType(), "OpenUrl", sb.ToString(), true);
        }       
    }

   
    #endregion

    #region 弹出消息提示,并且打开新页面 MessageBox.ShowUrl()
    /// <summary>
    /// 弹出消息提示,并且打开新页面
    /// </summary>
    /// <param name="page0">参数:Page</param>
    /// <param name="this0">参数:this</param>
    /// <param name="str">参数:消息提示文本内容</param>
    /// <param name="url">参数:新页面地址</param>
    public static void ShowUrl(Page page0, Page this0, string str, string url)
    {
        StringBuilder sb = new StringBuilder("");
        sb.Append("alert('" + str + "');");
        sb.Append("document.location.href='" + url + "';");    
        ClientScriptManager cs = page0.ClientScript;
        if (!cs.IsStartupScriptRegistered(this0.GetType(), "ShowUrl"))
        {
            cs.RegisterStartupScript(this0.GetType(), "ShowUrl", sb.ToString(), true);
        } 
    }


    #endregion

    #region 弹出询问消息提示,选择后打开新页面 MessageBox.ShowConfirmURL()
    /// <summary>
    /// 弹出询问消息提示,并且打开新页面
    /// </summary>
    /// <param name="page0">参数:Page</param>
    /// <param name="this0">参数:this</param>
    /// <param name="str">参数:消息提示文本内容</param>
    /// <param name="urlYes">参数:点选"确定"后导航的页面地址</param>
    /// <param name="urlNo">参数:点选"取消"后导航的页面地址</param>
    public static void ShowConfirmURL(Page page0, Page this0, string str, string urlYes, string urlNo)
    {
        StringBuilder sb = new StringBuilder("");
        sb.Append("if (window.confirm('" + str + "'))");
        sb.Append("{");
        if (urlYes != "")
        {
            sb.Append("  document.location.href='" + urlYes + "';");
        }
        else
        {
            sb.Append("  true;");
        }
        sb.Append("}");
        sb.Append("else");
        sb.Append("{");
        if (urlNo != "")
        {
            sb.Append("  document.location.href='" + urlNo + "';");
        }
        else
        {
            sb.Append("  false;");
        }
        sb.Append("}");
        ClientScriptManager cs = page0.ClientScript;
        if (!cs.IsStartupScriptRegistered(this0.GetType(), "ShowUrl"))
        {
            cs.RegisterStartupScript(this0.GetType(), "ShowUrl", sb.ToString(), true);
        }
    }

    /// <summary>
    /// AJAX
    /// </summary>
    /// <param name="control"></param>
    /// <param name="type"></param>
    /// <param name="str"></param>
    /// <param name="urlYes"></param>
    /// <param name="urlNo"></param>

    #endregion

    #region 非模态显示 MessageBox.showModelessDialog()
    /// <summary>
    /// 非模态显示
    /// </summary>
    /// <param name="page0">参数:Page</param>
    /// <param name="this0">参数:this</param>
    /// <param name="url">显示页面的地址</param>
    /// <param name="width">显示小窗口的宽度</param>
    /// <param name="height">显示小窗口的高度</param>
    public static void showModelessDialog(Page page0, Page this0, string url, int width, int height)
    {
        StringBuilder sb = new StringBuilder("");
        sb.Append("ReturnValue = window.showModelessDialog('" + url + "', window ,'dialogWidth=" + width.ToString() + "px;dialogHeight=" + height.ToString() + "px');");
        sb.Append("");
        ClientScriptManager cs = page0.ClientScript;
        if (!cs.IsStartupScriptRegistered(this0.GetType(), "showModelessDialog"))
        {
            cs.RegisterStartupScript(this0.GetType(), "showModelessDialog", sb.ToString(), true);
        }
    }
    #endregion

    #region 模态显示 MessageBox.showModalDialog()
    /// <summary>
    /// 模态显示
    /// </summary>
    /// <param name="page0">参数:Page</param>
    /// <param name="this0">参数:this</param>
    /// <param name="url">显示页面的地址</param>
    /// <param name="width">显示小窗口的宽度</param>
    /// <param name="height">显示小窗口的高度</param>
    /// <param name="HideName">接受弹出页面的回传值,一般用Hiddden或文本框来接受</param>
    public static void showModalDialog(Page page0, Page this0, string url, int width, int height, string HideName)
    {
        StringBuilder sb = new StringBuilder("");
        sb.Append("ReturnValue = window.showModalDialog('" + url + "', window ,'dialogWidth=" + width.ToString() + "px;dialogHeight=" + height.ToString() + "px');");
        sb.Append("window.document.getElementById('" + HideName + "').value = ReturnValue;");
        ClientScriptManager cs = page0.ClientScript;
        if (!cs.IsStartupScriptRegistered(this0.GetType(), "showModalDialog"))
        {
            cs.RegisterStartupScript(this0.GetType(), "showModalDialog", sb.ToString(), true);
        }
    }


    #endregion

    #region 关闭页面窗口 MessageBox.WinClose()
    /// <summary>
    /// 关闭页面窗口
    ///一般应用于服务器控件事件代码中,之前可执行其他代码;
    /// </summary>
    /// <param name="page0">参数:Page</param>
    /// <param name="this0">参数:this</param>
    public static void WinClose(Page page0, Page this0)
    {
        StringBuilder sb = new StringBuilder("");
        sb.Append(" window.dialogArguments.location.href =window.dialogArguments.location.href;");//刷新父页面
        sb.Append(" window.close();");
        ClientScriptManager cs = page0.ClientScript;
        if (!cs.IsStartupScriptRegistered(this0.GetType(), "WinClose"))
        {
            cs.RegisterStartupScript(this0.GetType(), "WinClose", sb.ToString(), true);
        }        
    }



    /// <summary>
    /// 关闭页面窗口
    ///一般应用于服务器控件事件代码中,之前可执行其他代码;
    /// </summary>
    /// <param name="page0">参数:Page</param>
    /// <param name="this0">参数:this</param>
    /// <param name="str">参数:返回值</param>
    public static void WinClose(Page page0, Page this0, string str)
    {
        StringBuilder sb = new StringBuilder("");
        sb.Append("window.returnValue = '" + str + "';");
        sb.Append("window.close();");
        ClientScriptManager cs = page0.ClientScript;
        if (!cs.IsStartupScriptRegistered(this0.GetType(), "WinClose1"))
        {
            cs.RegisterStartupScript(this0.GetType(), "WinClose1", sb.ToString(), true);
        }
    }


    #endregion

}

