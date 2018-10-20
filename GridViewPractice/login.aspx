<%@ Page Title="" Language="C#" MasterPageFile="~/Common_MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table border="0" style="width:100%;">
    <tr><td colspan="3" style="width:100%; height:100px;"></td></tr>
    <tr style="height:400px;"><td style="width:30%;"></td><td>
        <center>
           <table style="border-collapse:collapse; padding-left:100em; width:400px; height:400px" border="0" >
        <tr style="border:1px solid black">
            <td style="text-align:center" colspan="3">Login Form</td></tr>
        <tr style="border:1px solid black">
            <td style="text-align:center">UserName</td><td align="center"><asp:TextBox ID="tb_userName" runat="server"></asp:TextBox></td><td></td>
            </tr><tr style="border:1px solid black">
            <td align="center">Password</td><td align="center"><asp:TextBox ID="tb_password" TextMode="Password" runat="server"></asp:TextBox></td><td></td>
                </tr>
               <tr style="border:1px solid black">
            <td colspan="3" style="text-align:center;">
                <asp:Button 
                    ID="btn_submit" 
                    runat="server"  
                    OnClick="btn_submit_Click"
                    Text="Submit" 
                    Width="200px"/></td>
                   <asp:Label ID="lb_Message" Visible="false" runat="server" Font-Size="13px"></asp:Label>
        </tr>
    </table>
            </center>

    </td>
        <td style="width: 30%;"></td>
    </tr>
    <tr>
        <td colspan="3" style="width: 100%; height: 100px;"></td>
    </tr>
</table>

</asp:Content>

