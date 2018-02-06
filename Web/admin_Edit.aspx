<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_Edit.aspx.cs" Inherits="admin_Edit" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link rel="stylesheet" href="inc/css.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <table width="1052" border=0 align=center cellpadding=2 cellspacing=1 bordercolor="#799AE1" class=tableBorder>
        <tbody>
          <tr>
            <th align=center colspan=2 style="height: 23px">
                管理员信息修改</th>
          </tr>
          <tr bgcolor="#DEE5FA">
            <td colspan="2" align="center" class=txlrow>&nbsp;</td>
          </tr>
           <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                用户名:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="username" runat="server" Width="145px" ReadOnly="true"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="username" runat="server" ErrorMessage="请输入用户名"></asp:RequiredFieldValidator></td>
          </tr>
               <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                密码:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="password" runat="server" Width="144px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="password" runat="server" ErrorMessage="请输入密码"></asp:RequiredFieldValidator></td>
          </tr>
           
           
         
            <tr bgcolor="#DEE5FA">
            <td height="40" align="right" class="txlrow">&nbsp;</td>
            <td align=left class=txlrow>
                <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" />&nbsp;</td>
          </tr>
          <tr bgcolor="#DEE5FA">
            <td height="66" colspan=2 align=center class=txlrow></td>
          </tr>
         </tbody></table>
    </div>
    </form>
</body>
</html>
