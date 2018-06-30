<%@ Page  Language="C#" AutoEventWireup="true" CodeFile="Part9.aspx.cs" Inherits="Part9" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1" onrowdatabound="GridView1_RowDataBound">
        <Columns>
            <asp:BoundField DataField="EmployeeId" HeaderText="EmployeeId" 
                SortExpression="EmployeeId" />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" 
                SortExpression="FirstName" />
            <asp:BoundField DataField="AnnualSalary" HeaderText="AnnualSalary" 
                SortExpression="AnnualSalary" />
            <asp:BoundField DataField="CountryCulture" HeaderStyle-CssClass="DisplayNone" ItemStyle-CssClass="DisplayNone" HeaderText="CountryCulture" 
                SortExpression="CountryCulture" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:GridView_KudvankatConnectionString %>" 
        SelectCommand="SELECT * FROM [tblEmployees3]"></asp:SqlDataSource>
    
    <br />
    </form>
</body>
</html>
