<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultNew.aspx.cs" Inherits="WebApplication1.DefaultNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #0000FF;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 123px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 class="auto-style1">Validation Control Demo Series</h1>
    </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Name:</td>
                <td>
                    <asp:TextBox ID="NameTextBox" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="NameRequiredFieldValidator" runat="server" ControlToValidate="NameTextBox" Display="Dynamic" ErrorMessage="Name is Required" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Email:</td>
                <td>
                    <asp:TextBox ID="EmailTextBox" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="Email is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="Email is not in Correct Format (abc@xyz.com)" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Re-Enter Email:</td>
                <td>
                    <asp:TextBox ID="ReEnterEmailTextBox" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ReEnterEmailRequiredFieldValidator" runat="server" ControlToValidate="ReEnterEmailTextBox" Display="Dynamic" ErrorMessage="Re-Enter Email Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="ReEnterEmailRegularExpressionValidator" runat="server" ControlToValidate="ReEnterEmailTextBox" Display="Dynamic" ErrorMessage="Re-Emter Email is not in Correct Format" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="SubmitButton" runat="server" Text="Submit" Width="120px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
