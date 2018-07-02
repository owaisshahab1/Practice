<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Repeater.aspx.cs" Inherits="Repeater" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <%-- <asp:Repeater ID="rp_BU" runat="server" OnItemDataBound="rp_BU_ItemCommand" OnItemCreated="rp_BU_ItemCreated">
            <HeaderTemplate>
                <table class="mGrid" width="100%">
                    <tr style="background-color: #F1F8F8; border-color: White; border-width: 1px; border-style: Solid;">
                        <th colspan="3">
                        </th>
     
                    </tr>
                    <tr style="background-color: #F1F8F8; border-color: White; border-width: 1px; border-style: Solid;">
                        <th rowspan="3">
                            Group Name
                        </th>
                        <th rowspan="3">
                            Product Name
                        </th>
                        <th rowspan="3">
                            Trade Price
                        </th>
            
                    </tr>
                  
              
                    </tr>
                  
            </HeaderTemplate>
            <ItemTemplate>
                <tr style="background-color: #F1F8F8; border-color: White; border-width: 1px; border-style: Solid;">
                    <td>
                        <%# DataBinder.Eval(Container.DataItem, "GRP_NAME")%>
                    </td>
                    <td>
                        <%# DataBinder.Eval(Container.DataItem, "PRD_NAME")%>
                    </td>
                    <td>
                        <%# DataBinder.Eval(Container.DataItem, "new_trade")%>
                        <asp:Literal ID="lt_item" runat="server"></asp:Literal>
                    </td>

                    <asp:HiddenField ID="hd_GRP_NAME" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "GRP_NAME")%>' />
                    <asp:HiddenField ID="hd_Prdcd" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "PRDCD")%>' />
                    <asp:HiddenField ID="hd_Team" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "Team")%>' />
                    <asp:HiddenField ID="RowIndex" runat="server" />
                </tr>
                <asp:Literal ID="lt_subtotal" runat="server" Visible="false"></asp:Literal>
                <asp:Literal ID="lt_Team" runat="server" Visible="false"></asp:Literal>
            </ItemTemplate>
            <FooterTemplate>
                <tr style="background-color: #F1F8F8; border-color: White; border-width: 1px; border-style: Solid;">
                    <th colspan="3" align='center'>
                        Grand Total
                        <asp:Literal ID="lt_Footer" runat="server"></asp:Literal>
                    </th>
                </tr>
                </table>
            </FooterTemplate>
        </asp:Repeater>--%>

        <asp:Repeater ID="rptCustomers" runat="server">
    <HeaderTemplate>
        <table cellspacing="0" rules="all" border="1">
            <tr>
                <th scope="col" style="width: 80px">
                    ProductName
                </th>
                <th scope="col" style="width: 120px">
                    UnitPrice
                </th>
                <th scope="col" style="width: 100px">
                    UnitsInStock
                </th>
                   <th scope="col" style="width: 100px">
                    UnitsOnOrder
                </th>
                   <th scope="col" style="width: 100px">
                    ReorderLevel
                </th>
            </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td>
                <asp:Label ID="lblProductName" runat="server" Text='<%# Eval("ProductName") %>' />
            </td>
            <td>
                <asp:Label ID="lblUnitPrice" runat="server" Text='<%# Eval("UnitPrice") %>' />
            </td>
            <td>
                <asp:Label ID="lblUnitsInStock" runat="server" Text='<%# Eval("UnitsInStock") %>' />
            </td>
                   <td>
                <asp:Label ID="LabelUnitsOnOrder" runat="server" Text='<%# Eval("UnitsOnOrder") %>' />
            </td>
                   <td>
                <asp:Label ID="LabelReorderLevel" runat="server" Text='<%# Eval("ReorderLevel") %>' />
            </td>
               
        </tr>
    </ItemTemplate>
    <FooterTemplate>
           <tr>
                <th scope="col" style="width: 80px">
                    Total
                </th>
                <th scope="col" style="width: 120px">
                   Total UnitPrice
                </th>
                <th scope="col" style="width: 100px">
                  Total  UnitsInStock
                </th>
                   <th scope="col" style="width: 100px">
                   Total UnitsOnOrder
                </th>
                   <th scope="col" style="width: 100px">
                   Total ReorderLevel
                </th>
            </tr>
        </table>
    </FooterTemplate>
</asp:Repeater>
    </div>
    </form>
</body>
</html>
