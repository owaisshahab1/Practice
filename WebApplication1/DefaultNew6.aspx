<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultNew6.aspx.cs" Inherits="WebApplication1.DefaultNew6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="msgDiv" runat="server" visible="false" >
        <asp:Label ID="WelcomeLabel" runat="server"/></div>
        <div id="txtDiv" runat="server" visible="false" >
            Name: <asp:TextBox ID="NameTextBox" runat="server" /><br /><br />
            <asp:Button ID="SignUpButton" Text="Sign Up" runat="server" OnClick="SignUpButton_Click" />
        </div>
    </div>
    </div>
    </form>
</body>
</html>
