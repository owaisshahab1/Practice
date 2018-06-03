<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultNew2.aspx.cs" Inherits="WebApplication1.DefaultNew1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            Name:
        <asp:TextBox ID="NameTextBox" runat="server" /><br /><br />
        <asp:Button ID="NextPageButton" Text="Next Page" runat="server" OnClick="NextPageButton_Click"/>
    </div>
    </form>
</body>
</html>
