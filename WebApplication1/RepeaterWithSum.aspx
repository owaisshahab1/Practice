<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterWithSum.aspx.cs" Inherits="WebApplication1.RepeaterWithSum" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
    <style type="text/css">
        body {
            font-family: Arial;
            font-size: 10pt;
        }
                table
        {
            border: 1px solid #ccc;
            border-collapse: collapse;
        }
                        table th
        {
            background-color: #F7F7F7;
            color: #333;
            font-weight: bold;
        }
                    table th, table td {
                        padding: 5px;
                        border: 1px solid #ccc;
                    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater ID="rptCustomers" OnItemCreated="rptCustomers_ItemCreated" OnItemCommand="rptCustomers_ItemCommand" OnItemDataBound="rptCustomers_ItemDataBound" runat="server">
            <HeaderTemplate>
                <table cellspacing="0" rules="all" border="1">
                <tr>
                    <th scope="col" style="width: 80px">ID</th>


                    <th scope="col" style="width: 120px">FIRST NAME</th>

                    <th scope="col" style="width: 120px">LAST NAME</th>

                    <th scope="col" style="width: 100px">CITY</th>


                    <th scope="col" style="width: 80px">COUNTRY</th>
                    <th scope="col" style="width: 80px">PHONE</th>
                </tr>

            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="lblCustomerId" runat="server" Text='<%# Eval("Id") %>' />
                    </td>
                    <td>
                        <asp:Label ID="lblContactName" runat="server" Text='<%# Eval("FirstName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="lblCompanyName" runat="server" Text='<%# Eval("LastName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("City") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Country") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Phone") %>' />
                    </td>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
