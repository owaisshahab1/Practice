<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AspDotNetPart22.aspx.cs" Inherits="AspDotNetPart22" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:DropDownList ID="ddlCategories" AutoPostBack="true" DataTextField="CategoryName" DataValueField="CategoryID" Width="200px" runat="server" 
            onselectedindexchanged="ddlCategories_SelectedIndexChanged"></asp:DropDownList>
    <br /><br />
        <asp:DropDownList ID="ddlProducts" AutoPostBack="true" 
            DataTextField="ProductName" DataValueField="ProductID" Width="200px" 
            runat="server" onselectedindexchanged="ddlProducts_SelectedIndexChanged"></asp:DropDownList>
    <br /><br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>

    </div>
    </form>
</body>
</html>
