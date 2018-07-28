<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerTableWithRepeater.aspx.cs" Inherits="CustomerTableWithRepeater" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddlCountry" AutoPostBack="true"  DataTextField="CountryName" 
            DataValueField="CountryId" runat="server" 
            onselectedindexchanged="ddlCountry_SelectedIndexChanged" Width="200px">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlCity" AutoPostBack="true"  DataTextField="CityName" 
            DataValueField="CityId" Width="200px" runat="server">
        </asp:DropDownList>
        <asp:Repeater  ID="Repeater1" runat="server" 
            onitemcreated="Repeater1_ItemCreated">
            <ItemTemplate>
            <table>
            <tr><td>
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </td></tr>
            </table>
            </ItemTemplate>
        </asp:Repeater>

    </div>

    </form>
</body>
</html>
