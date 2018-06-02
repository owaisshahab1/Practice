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
            width: 600px;
        }
        .auto-style3 {
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
                <td class="auto-style3" colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="#FFFF99" BorderColor="#CCCCCC" ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Name:</td>
                <td>
                    <asp:TextBox ID="NameTextBox" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="NameRequiredFieldValidator" runat="server" ControlToValidate="NameTextBox" Display="Dynamic" ErrorMessage="Name is Required" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Email:</td>
                <td>
                    <asp:TextBox ID="EmailTextBox" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="Email is Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="Email is not in Correct Format (abc@xyz.com)" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Re-Enter Email:</td>
                <td>
                    <asp:TextBox ID="ReEnterEmailTextBox" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ReEnterEmailRequiredFieldValidator" runat="server" ControlToValidate="ReEnterEmailTextBox" Display="Dynamic" ErrorMessage="Re-Enter Email Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="ReEnterEmailRegularExpressionValidator" runat="server" ControlToValidate="ReEnterEmailTextBox" Display="Dynamic" ErrorMessage="Re-Emter Email is not in Correct Format" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    <asp:CompareValidator ID="ReEnterEmailCompareValidator" runat="server" ControlToCompare="EmailTextBox" ControlToValidate="ReEnterEmailTextBox" ErrorMessage="Re-Enter Email Must be same" ForeColor="Red">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Age:</td>
                <td>
                    <asp:TextBox ID="AgeTextBox" runat="server" Width="195px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="AgeRequiredFieldValidator" runat="server" ControlToValidate="AgeTextBox" Display="Dynamic" ErrorMessage="Age is Required" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="AgeRangeValidator" runat="server" ControlToValidate="AgeTextBox" Display="Dynamic" ErrorMessage="Age Should between 18 and 99" ForeColor="Red" MaximumValue="99" MinimumValue="18" SetFocusOnError="True" Type="Integer">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Date Of Birth:</td>
                <td>
                    <asp:TextBox ID="DOBTextBox" runat="server" Width="191px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="DOBRequiredFieldValidator" runat="server" ControlToValidate="DOBTextBox" Display="Dynamic" ErrorMessage="Date of Birth is Required" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="DOBRangeValidator" runat="server" ControlToValidate="DOBTextBox" Display="Dynamic" ErrorMessage="You should be over 18 years old" ForeColor="Red" MaximumValue="03/06/2001" MinimumValue="03/06/1919" SetFocusOnError="True" Type="Date">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Donate Amount:</td>
                <td>
                    <asp:TextBox ID="DonationAmountTextBox" runat="server" Width="186px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="DonationAmountRequiredFieldValidator" runat="server" ControlToValidate="DonationAmountTextBox" Display="Dynamic" ErrorMessage="Donation Amount is Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="DonationAmountRangeValidator" runat="server" ControlToValidate="DonationAmountTextBox" Display="Dynamic" ErrorMessage="Donation Amount should between 5 and 100" ForeColor="Red" MaximumValue="100" MinimumValue="5" Type="Double">*</asp:RangeValidator>
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
