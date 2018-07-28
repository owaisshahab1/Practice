<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PageToQuiz.aspx.cs" Inherits="PageToQuiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lb" Text="Press Below Button For Quiz" runat="server" Font-Size="50pt" Width="863px" />
       
    </div>
         <asp:Button   ID="btn" Text="Go To Quiz" runat="server" Width="832px" OnClick="btn_Click" />
    </form>
</body>
</html>
