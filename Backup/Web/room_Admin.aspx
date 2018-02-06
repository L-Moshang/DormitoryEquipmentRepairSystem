﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="room_Admin.aspx.cs" Inherits="room_Admin" %>


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
        <th align=center colspan=16 style="height: 23px">
         宿舍管理</th>
      </tr>
      <tr bgcolor="#DEE5FA">
        <td colspan="16" align="center" class=txlrow>
        
                <table width="600" height="30" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="138" align="right">
        宿舍号：&nbsp;</td>
    <td width="262" align="left">&nbsp;<asp:TextBox ID="key" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="搜索" OnClick="Button1_Click" /></td>
    <td width="200">&nbsp;</td>
  </tr>
</table>
            <asp:GridView ID="GridView1"   AutoGenerateColumns="False"   OnPageIndexChanging="GridView1_PageIndexChanging" CssClass="tab"  runat="server" Width="100%" DataKeyNames="id">
                        <Columns>
                                            <asp:BoundField DataField="louhao" HeaderText="楼号" />     
                                             <asp:BoundField DataField="loucheng" HeaderText="楼层" /> 
                                              <asp:BoundField DataField="roomno" HeaderText="宿舍号" />     
                                             <asp:BoundField DataField="person" HeaderText="入住人数" /> 
                                             <asp:BoundField DataField="telphone" HeaderText="电话" />     
                                                              <asp:TemplateField HeaderText="违章记录" >
            <ItemTemplate>
 <a href="events_detail.aspx?roomno=<%# Eval("roomno") %>" >查看</a> 
  </ItemTemplate> 
              </asp:TemplateField>
                                             <asp:BoundField DataField="weisheng" HeaderText="卫生" />     
                                                              
                            <asp:TemplateField HeaderText="操作" >
            <ItemTemplate>
 <a href="room_delete.aspx?id=<%# Eval("id") %>" >删除</a> &nbsp;&nbsp;<a href="room_Edit.aspx?id=<%# Eval("id") %>" >修改</a> 
  </ItemTemplate> 
              </asp:TemplateField>
                                
                        </Columns>
                          <PagerTemplate>
                                                 <br />
                                                 <asp:Label ID="lblPage" runat="server" Text='<%# "第" + (((GridView)Container.NamingContainer).PageIndex + 1)  + "页/共" + (((GridView)Container.NamingContainer).PageCount) + "页" %> '></asp:Label>
                                                 <asp:LinkButton ID="lbnFirst" runat="Server" Text="首页"  Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>' CommandName="Page" CommandArgument="First" ></asp:LinkButton>
                                                 <asp:LinkButton ID="lbnPrev" runat="server" Text="上一页" Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>' CommandName="Page" CommandArgument="Prev"  ></asp:LinkButton>
                                                 <asp:LinkButton ID="lbnNext" runat="Server" Text="下一页" Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != (((GridView)Container.NamingContainer).PageCount - 1) %>' CommandName="Page" CommandArgument="Next" ></asp:LinkButton>
                                                 <asp:LinkButton ID="lbnLast" runat="Server" Text="尾页"   Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != (((GridView)Container.NamingContainer).PageCount - 1) %>' CommandName="Page" CommandArgument="Last" ></asp:LinkButton>
                                                 <br />
                                             </PagerTemplate>
                    </asp:GridView>
            
            
            </td>
      </tr>
    
       
   
    
     </tbody></table>
    </div>
    </form>
</body>
</html>
