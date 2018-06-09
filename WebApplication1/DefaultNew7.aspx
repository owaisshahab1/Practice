<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultNew7.aspx.cs" Inherits="WebApplication1.DefaultNew7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #0066FF;
        }
        .auto-style2 {
            width: 450px;
        }
        .auto-style3 {
            width: 84px;
        }
    </style>
    <script type="text/javascript">
        function GenderValidation(sender, e) {
            var male = document.getElementById('MaleRadioButton').checked;
            var female = document.getElementById('FemaleRadioButton').checked;
            if (male == true || female == true) {
                e.IsValid = true;
            }
            else {
                e.IsValid = false;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 class="auto-style1">ASP.NET database tipes and tricks</h1>
    </div>
    <table cellpadding="0" cellspacing="0" class="auto-style2">
        <tr>
            <td colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="47px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Name:</td>
            <td>
                <asp:TextBox ID="NameTextBox" runat="server" Width="218px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="NameRequiredFieldValidator" runat="server" ControlToValidate="NameTextBox" Display="Dynamic" ErrorMessage="Name is Required!" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Email:</td>
            <td>
                <asp:TextBox ID="EmailTextBox" runat="server" Width="214px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="Email is Required!" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="Email is not in Correct format." ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Gender:</td>
            <td>
                <asp:RadioButton ID="MaleRadioButton" runat="server" GroupName="Gender" Text="Male" />
                <asp:RadioButton ID="FemaleRadioButton" runat="server" GroupName="Gender" Text="Female" />
                <asp:CustomValidator ID="GenderCustomValidator" runat="server" ClientValidationFunction="GenderValidation" Display="Dynamic" ErrorMessage="Please select gender" ForeColor="Red">*</asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:CheckBox ID="PersonalizedEmailCheckBox" runat="server" Text="Yes, Please send me personalized emails" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" Width="102px" OnClick="SubmitButton_Click" />
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>
