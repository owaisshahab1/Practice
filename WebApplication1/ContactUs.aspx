<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="WebApplication1.ContactUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 141px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Contact Us Page</h3>
    <p>Please fill the form below.<table align="center" cellpadding="0" cellspacing="0" class="auto-style1">
        <tr>
            <td class="auto-style2">Name:</td>
            <td>
                <asp:TextBox ID="NameTextBox" runat="server" Width="330px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Email:</td>
            <td>
                <asp:TextBox ID="EmailTextBox" runat="server" OnTextChanged="NameTextBox0_TextChanged" Width="330px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Subject:</td>
            <td>
                <asp:DropDownList ID="SubjectDropDownList" runat="server" Height="16px" Width="182px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Message:</td>
            <td>
                <asp:TextBox ID="MessageTextBox" runat="server" Height="74px" OnTextChanged="NameTextBox0_TextChanged" TextMode="MultiLine" Width="330px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" />
            </td>
        </tr>
        </table>
    </p>
</asp:Content>
