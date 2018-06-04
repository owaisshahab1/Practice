<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultNew4.aspx.cs" Inherits="WebApplication1.DefaultNew4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Name: <asp:TextBox ID="NameTextBox" runat="server" /><br />
        Date Of Birth: <asp:TextBox ID="DOBTextBox" runat="server" /><br /><br />
        <asp:Button ID="NextPageButton" runat="server" text="Next Page" OnClick="NextPageButton_Click"/>
    </div>
    </form>
</body>
</html>
