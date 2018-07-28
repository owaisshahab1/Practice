<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuizPage.aspx.cs" Inherits="QuizPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
    <div>

           <asp:Label ID="Label1" runat="server" Font-Size="50pt" Width="863px" />
        <asp:TextBox ID="txbx" runat="server" />
        <asp:Button ID="btn" Text="Submit your Answer" runat="server" OnClick="btn_Click" />
        <asp:Label ID="Label2" runat="server" Visible="false" Font-Size="50pt" Width="863px" />
        </div>
    </form>
</body>
</html>
