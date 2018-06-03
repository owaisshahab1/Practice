<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="DefaultNew3.aspx.cs" Inherits="WebApplication1.DefaultNew3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        Name:
    <asp:TextBox ID="NameTextBox" runat="server" /><br /><br />
    <asp:Button ID="NextPageButton" Text="Next Page" runat="server" OnClick="NextPageButton_Click" />
</asp:Content>
