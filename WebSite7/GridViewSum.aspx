<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViewSum.aspx.cs" Inherits="GridViewSum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
              <Columns>
                  <asp:BoundField DataField="Id" HeaderText="Id dfsdfsd" ReadOnly="True" SortExpression="Id dasda" />
                  <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                  <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                  <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                  <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                  <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                  <asp:BoundField DataField="Region" HeaderText="Region" SortExpression="Region" />
                  <asp:BoundField DataField="Total" HeaderText="Total" SortExpression="Total" />
              </Columns>
          </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NewDemoConnectionString %>" SelectCommand="SELECT * FROM [CustomersNew]"></asp:SqlDataSource>
    </form>
  
</body>
</html>
