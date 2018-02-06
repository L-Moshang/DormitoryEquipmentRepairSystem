<%@ Page Language="C#" AutoEventWireup="true" CodeFile="room_Edit.aspx.cs" Inherits="room_Edit" %>

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
                宿舍信息修改</th>
          </tr>
          <tr bgcolor="#DEE5FA">
            <td colspan="2" align="center" class=txlrow>&nbsp;</td>
          </tr>
           <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                楼号:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="louhao" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="louhao" runat="server" ErrorMessage="请输入楼号"></asp:RequiredFieldValidator></td>
          </tr>

             <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                楼层:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="loucheng" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="loucheng" runat="server" ErrorMessage="请输入楼层"></asp:RequiredFieldValidator></td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                宿舍号:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="roomno" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="roomno" runat="server" ErrorMessage="请输入宿舍号"></asp:RequiredFieldValidator></td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                入住人数:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="person" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="person" runat="server" ErrorMessage="请输入入住人数"></asp:RequiredFieldValidator></td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                电话号码:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="telphone" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="telphone" runat="server" ErrorMessage="请输入电话号码"></asp:RequiredFieldValidator></td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                违章记录:</td>
            <td align=left class=txlrow>&nbsp;&nbsp;
                <asp:RadioButton ID="r1" GroupName="r" runat="server" Text="有" />
                <asp:RadioButton ID="r2" GroupName="r" runat="server" Text="无" /></td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                宿舍卫生:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="weisheng" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="weisheng" runat="server" ErrorMessage="请输入宿舍卫生"></asp:RequiredFieldValidator></td>
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
