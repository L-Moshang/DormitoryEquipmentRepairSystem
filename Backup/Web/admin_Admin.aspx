<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_Admin.aspx.cs" Inherits="admin_Admin" %>

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
            管理员管理</th>
      </tr>
      <tr bgcolor="#DEE5FA">
        <td colspan="16" align="center" class=txlrow>
            <asp:GridView ID="GridView1"   AutoGenerateColumns="False"   OnRowDataBound="GridView1_RowDataBound"   OnPageIndexChanging="GridView1_PageIndexChanging" CssClass="tab"  runat="server" Width="100%" DataKeyNames="id">
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="编号" />
                            <asp:BoundField DataField="username" HeaderText="用户名" />
                             <asp:BoundField DataField="password" HeaderText="密码" />  
                                                          
                            <asp:TemplateField HeaderText="操作" >
            <ItemTemplate>
 <a href="admin_delete.aspx?id=<%# Eval("id") %>" >删除</a> &nbsp;&nbsp;<a href="admin_Edit.aspx?id=<%# Eval("id") %>" >修改</a> 
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
