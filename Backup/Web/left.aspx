<%@ Page Language="C#" AutoEventWireup="true" CodeFile="left.aspx.cs" Inherits="admin_left" %>


<html  >
<head runat="server">
    <title>无标题页</title>
    <STYLE type=text/css>
BODY {
	BACKGROUND: #799ae1; MARGIN: 0px; FONT: 9pt 宋体
}
TABLE {
	BORDER-RIGHT: 0px; BORDER-TOP: 0px; BORDER-LEFT: 0px; BORDER-BOTTOM: 0px
}
TD {
	FONT: 12px 宋体
}
IMG {
	BORDER-RIGHT: 0px; BORDER-TOP: 0px; VERTICAL-ALIGN: bottom; BORDER-LEFT: 0px; BORDER-BOTTOM: 0px
}
A {
	FONT: 12px 宋体; COLOR: #000000; TEXT-DECORATION: none
}
A:hover {
	COLOR: #428eff; TEXT-DECORATION: underline
}
.sec_menu {
	BORDER-RIGHT: white 1px solid; BACKGROUND: #d6dff7; OVERFLOW: hidden; BORDER-LEFT: white 1px solid; BORDER-BOTTOM: white 1px solid
}
.menu_title {
	
}
.menu_title SPAN {
	FONT-WEIGHT: bold; LEFT: 7px; COLOR: #215dc6; POSITION: relative; TOP: 2px
}
.menu_title2 {
	
}
.menu_title2 SPAN {
	FONT-WEIGHT: bold; LEFT: 8px; COLOR: #428eff; POSITION: relative; TOP: 2px
}
</STYLE>

</head>
<body>
    <form id="form1" runat="server">
    <div>
   <TABLE cellSpacing=0 cellPadding=0 width="100%" align=left border=0>
  <TBODY>
  <TR>
    <TD vAlign=top bgColor=#799ae1>
      <TABLE cellSpacing=0 cellPadding=0 width=158 align=center>
        <TBODY>
        <TR>
          <TD vAlign=bottom height=42><IMG height=38 
            src="images/title.gif" width=158> </TD></TR></TBODY></TABLE>
      <TABLE cellSpacing=0 cellPadding=0 width=158 align=center>
        <TBODY>
        <TR>
          <TD class=menu_title onMouseOver="this.className='menu_title2';" 
          onmouseout="this.className='menu_title';" background="" 
            height=25><SPAN>欢迎<%=admin %>登陆| <A 
            href="outs.aspx" 
            target=_parent><B>退出</B></A></SPAN></TD>
        </TR>

        </TBODY></TABLE>
	  <TABLE cellSpacing=0 cellPadding=0 width=158 align=center>
        <TBODY>

        <TR>
          <TD id=submenu0 style="width: 161px">
            <DIV class=sec_menu style="WIDTH: 158px ">
            <TABLE cellSpacing=0 cellPadding=0 width=135 align=center>
              <TBODY>
              <TR>
                <TD style="height: 624px" valign="top">
                    <asp:Panel ID="P1" runat="server" Height="50px" Width="125px">
                  
                <asp:TreeView ID="T1" runat="server"  Target="mainFrame" DataSourceID="SiteMapDataSource1"
                ShowLines="True">
                <DataBindings>
                    <asp:TreeNodeBinding DataMember="SiteMapNode" TextField="Title" NavigateUrlField="Url" />
                </DataBindings>
            </asp:TreeView>
            <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
              </asp:Panel>
                    <asp:Panel ID="P2" runat="server" Height="50px" Width="125px">
                 
            
                  <asp:TreeView ID="T2" runat="server"  Target="mainFrame"  Style="vertical-align: middle; text-align: left" Width="134px" ShowLines="true">
                            <Nodes>
                                <asp:TreeNode Text="菜单" Value="1">
                                
                                    <asp:TreeNode Text="个人信息管理" Value="2" >
                                         <asp:TreeNode Text="查看个人信息" Value="2" NavigateUrl="myinfo.aspx"></asp:TreeNode>
                                        <asp:TreeNode Text="修改密码" Value="5" NavigateUrl="pass.aspx"></asp:TreeNode>
                                    </asp:TreeNode>
                                  <asp:TreeNode Text="报修记录" Value="2" >
                                         <asp:TreeNode Text="我要报修" Value="2" NavigateUrl="repair_Add.aspx"></asp:TreeNode>
                                          <asp:TreeNode Text="查看我的报修" Value="2" NavigateUrl="myrepair.aspx"></asp:TreeNode>
                             
                                    </asp:TreeNode>
                              
                                  
                                </asp:TreeNode>
                            </Nodes>
                        </asp:TreeView>  
                           </asp:Panel>
                </TD>
              </TR>
               
             
              </TBODY></TABLE>
            </DIV>
            </TD></TR></TBODY></TABLE>
	  
	
      </TR></TBODY></TABLE>
    </div>
    </form>
</body>
</html>
