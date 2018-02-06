<%@ Page Language="C#" AutoEventWireup="true" CodeFile="stu_detail.aspx.cs" Inherits="stu_detail" %>


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
               学生详细信息</th>
          </tr>
          <tr bgcolor="#DEE5FA">
            <td colspan="2" align="center" class=txlrow>&nbsp;</td>
          </tr>
           <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow" style="width: 293px">
                学号:</td>
            <td align=left class=txlrow>&nbsp;
                <asp:Label ID="stuno" runat="server" Text="Label"></asp:Label>
            &nbsp;
                </td>
          </tr>

             <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow" style="width: 293px">
                姓名:</td>
            <td align=left class=txlrow>&nbsp;
                <asp:Label ID="name" runat="server" Text="Label"></asp:Label>
            &nbsp;
                </td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow" style="width: 293px">
                宿舍号:</td>
            <td align=left class=txlrow>&nbsp;
                <asp:Label ID="roomno" runat="server" Text="Label"></asp:Label> 
            &nbsp;
                </td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow" style="width: 293px">
                专业:</td>
            <td align=left class=txlrow>&nbsp;
                <asp:Label ID="zhuanye" runat="server" Text="Label"></asp:Label>
            &nbsp;
                </td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow" style="width: 293px">
                床号:</td>
            <td align=left class=txlrow>&nbsp;
                <asp:Label ID="bedno" runat="server" Text="Label"></asp:Label>
            &nbsp;
                </td>
          </tr>

    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow" style="width: 293px">
                性别:</td>
            <td align=left class=txlrow>&nbsp;&nbsp;<asp:Label ID="sex" runat="server" Text="Label"></asp:Label></td>
          </tr>

  
  <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow" style="width: 293px">
                入住年月:</td>
            <td align=left class=txlrow>&nbsp;<asp:Label
                ID="intime" runat="server" Text="Label"></asp:Label>&nbsp;
               </td>
          </tr>
            <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow" style="width: 293px">
                学生联系电话:</td>
            <td align=left class=txlrow>&nbsp;
                <asp:Label ID="stuphone" runat="server" Text="Label"></asp:Label>
           &nbsp;
              </td>
          </tr>
            <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow" style="width: 293px">
                导师联系电话:</td>
            <td align=left class=txlrow>&nbsp;
                <asp:Label ID="teaphone" runat="server" Text="Label"></asp:Label>
            &nbsp;
               </td>
          </tr>
    <tr bgcolor="#DEE5FA">
            <td height="29" align="right" class="txlrow" style="width: 293px">
                离寝时间（年月日）:</td>
            <td align=left class=txlrow>&nbsp;
                <asp:Label ID="outtime" runat="server" Text="Label"></asp:Label>
            
           
                </td>
          </tr>

            <tr bgcolor="#DEE5FA">
            <td height="40" align="right" class="txlrow" style="width: 293px">&nbsp;</td>
            <td align=left class=txlrow>
               &nbsp;</td>
          </tr>
          <tr bgcolor="#DEE5FA">
            <td height="66" colspan=2 align=center class=txlrow></td>
          </tr>
         </tbody></table>
    </div>
    </form>
</body>
</html>
