<%@ Page Language="C#" AutoEventWireup="true" CodeFile="repair_Add.aspx.cs" Inherits="repair_Add" %>

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
             报修物品信息添加</th>
          </tr>
          <tr bgcolor="#DEE5FA">
            <td colspan="2" align="center" class=txlrow>&nbsp;</td>
          </tr>
           <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                报修物品名称:</td>
            <td align=left class=txlrow>&nbsp;
                <asp:DropDownList ID="name" runat="server">
                
                </asp:DropDownList>
            
            </td>
          </tr>

             <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                报修宿舍号:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="roomno" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="roomno" runat="server" ErrorMessage="请输入报修宿舍号"></asp:RequiredFieldValidator></td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                报修人姓名:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="sname" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="sname" runat="server" ErrorMessage="请输入报修人姓名"></asp:RequiredFieldValidator></td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                报修人学号:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="stuno" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="stuno" runat="server" ErrorMessage="请输入报修人学号"></asp:RequiredFieldValidator></td>
          </tr>
    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                报修时间:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="madetime" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="madetime" runat="server" ErrorMessage="请输入报修时间"></asp:RequiredFieldValidator></td>
          </tr>
          <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                物品损坏原因:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="reason"  TextMode="MultiLine" runat="server" Width="399px" Height="179px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="reason" runat="server" ErrorMessage="请输入物品损坏原因"></asp:RequiredFieldValidator></td>
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

