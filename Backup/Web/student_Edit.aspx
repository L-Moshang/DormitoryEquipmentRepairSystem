<%@ Page Language="C#" AutoEventWireup="true" CodeFile="student_Edit.aspx.cs" Inherits="student_Edit" %>


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
               学生信息修改</th>
          </tr>
          <tr bgcolor="#DEE5FA">
            <td colspan="2" align="center" class=txlrow>&nbsp;</td>
          </tr>
           <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                学号:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="stuno" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="stuno" runat="server" ErrorMessage="请输入学号"></asp:RequiredFieldValidator></td>
          </tr>

             <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                姓名:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="name" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="name" runat="server" ErrorMessage="请输入姓名"></asp:RequiredFieldValidator></td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                宿舍号:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="roomno" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="roomno" runat="server" ErrorMessage="请输入宿舍号"></asp:RequiredFieldValidator></td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                专业:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="zhuanye" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="zhuanye" runat="server" ErrorMessage="请输入专业"></asp:RequiredFieldValidator></td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                床号:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="bedno" runat="server" Width="145px"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="bedno" runat="server" ErrorMessage="请输入床号"></asp:RequiredFieldValidator></td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                性别:</td>
            <td align=left class=txlrow>&nbsp;&nbsp;
                <asp:RadioButton ID="r1" GroupName="r" runat="server" Text="女" />
                <asp:RadioButton ID="r2" GroupName="r" runat="server" Text="男" /></td>
          </tr>

  
  <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                入住年月:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="intime" runat="server" Width="145px"></asp:TextBox>&nbsp;
               </td>
          </tr>
            <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow">
                学生联系电话:</td>
            <td align=left class=txlrow>&nbsp;<asp:TextBox ID="stuphone" runat="server" Width="145px"></asp:TextBox>&nbsp;
              </td>
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
