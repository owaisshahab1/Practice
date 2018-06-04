<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultNew5.aspx.cs" Inherits="WebApplication1.DefaultNew5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   First Name: <asp:TextBox ID="FirstNameTextBox" runat="server" /><br />
      Last  Name: <asp:TextBox ID="LastNameTextBox" runat="server" /><br /><br />
        <asp:Button ID="NextPageButton" Text="Next Page" runat="server" OnClick="NextPageButton_Click" />
    </div>
    </form>
</body>
</html>
