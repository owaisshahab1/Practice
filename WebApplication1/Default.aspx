<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="MessageLabel" runat="server" Text="MessageLabel"></asp:Label>
        <asp:Button ID="ShowMessageButton" runat="server" OnClick="ShowMessageButton_Click" Text="Show Message" Width="140px" />
    
    </div>
    </form>
</body>
</html>
