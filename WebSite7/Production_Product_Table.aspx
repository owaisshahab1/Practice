<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation = "false" CodeFile="Production_Product_Table.aspx.cs" Inherits="Production_Product_Table" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <%-- <asp:ScriptManager runat="server"></asp:ScriptManager>--%>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
        <asp:Panel ID="Panel1" runat="server">
             <asp:Label ID="Label1" runat="server" Text="Select Color   "></asp:Label>
        <asp:DropDownList ID="ddlColors"  runat="server" Visible="true" Width="200px" AutoPostBack="true" Height="30px" OnSelectedIndexChanged="ddlColors_SelectedIndexChanged"></asp:DropDownList>
            <asp:Label ID="Label3" runat="server" Text="Select Size(less than)  "></asp:Label>
                  <asp:DropDownList ID="ddlSize"  runat="server" Visible="true" Width="200px" AutoPostBack="true" Height="30px" OnSelectedIndexChanged="ddlSize_SelectedIndexChanged"></asp:DropDownList>
     <%--                      <ajaxToolkit:ComboBox ID="cbColors" DataMember="ColorsName" DataValueField="ColorsId" runat="server">
             </ajaxToolkit:ComboBox>--%>
                           </asp:Panel>
        <asp:Panel ID="Panel2" runat="server"><asp:Label ID="Label2" runat="server" Text="How Many Records Do you want to Select: "></asp:Label>
            <asp:TextBox ID="tbRecordQuantity" runat="server" Width="100px"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server"></asp:Panel>
        <asp:Panel ID="Panel4" runat="server"><asp:Button Text="Submit" ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" />
            <asp:Button Text="Export To Excel" ID="ExcelBtn" runat="server" OnClick="ExcelBtn_Click" />
        </asp:Panel>
    <asp:GridView ID="gvProduct" SortedAscendingCellStyle-Font-Underline="True" AllowSorting="True" runat="server" >
        <SortedAscendingCellStyle Font-Underline="True" />
        </asp:GridView>
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksConnectionString %>" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
