﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pass.aspx.cs" Inherits="pass" %>


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
               密码修改</th>
          </tr>
          <tr bgcolor="#DEE5FA">
            <td colspan="2" align="center" class=txlrow>&nbsp;</td>
          </tr>
           <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                新密码:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="pass2" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="pass2" runat="server" ErrorMessage="请输入新密码"></asp:RequiredFieldValidator></td>
          </tr>
       <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                确认密码:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="pass3" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="pass3" runat="server" ErrorMessage="请输入确认密码"></asp:RequiredFieldValidator></td>
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
