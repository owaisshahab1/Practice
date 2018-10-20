<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewUserEntry.aspx.cs" Inherits="NewUserEntry" %>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        td{
            padding-left:0.5em;
        }
        .TextBox{
            padding-left:0em;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="0" style="border-collapse:collapse; width:100%">
        <tr style="height:100px"><td>&nbsp;</td></tr>
        <tr style="height:400px">
            <td>
                <table border="0" style="border-collapse:collapse; width:100%;" spellcheck="true">
                    <tr>
                        <td style="width:35%"></td><td style="border:1px solid Black; width:15%">New User Id</td><td style="border:1px solid Black; width:15%">
                            <asp:Label ID="lb_userId" runat="server" ></asp:Label>
                                                                                                                 </td><td style="width:35%"></td>
                    </tr>
                      <tr>
                        <td></td><td style="border:1px solid Black;">User Name</td><td style="border:1px solid Black;" class="TextBox">
                            <asp:TextBox ID="tb_UserName" Width="200px" ToolTip="Enter UserName" runat="server"></asp:TextBox>
                                                                                  </td><td>
                                                                                        <asp:RequiredFieldValidator ID="rfv_tb_UserName" ForeColor="Red" runat="server" ControlToValidate="tb_UserName" ErrorMessage="Please Fill the Data">*</asp:RequiredFieldValidator>
                                                                                       </td>
                    </tr>
                      <tr>
                        <td></td><td style="border:1px solid Black">Password</td><td style="border:1px solid Black;" class="TextBox">
                            <asp:TextBox ID="tb_password" Width="200px" TextMode="Password" runat="server" ></asp:TextBox>
                                                                                 </td><td>
                                                                                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1_tb_password" ForeColor="Red" runat="server" ControlToValidate="tb_password" ErrorMessage="Please Fill the Password">*</asp:RequiredFieldValidator>
                                                                                      </td>
                    </tr>
                      <tr>
                        <td></td><td style="border:1px solid Black">Confirm Password</td><td style="border:1px solid Black;" class="TextBox">
                            <asp:TextBox ID="tb_ConfrmPassword" Width="200px" TextMode="Password" runat="server" ></asp:TextBox>
                                                                                         </td><td>
                                                                                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" runat="server" ControlToValidate="tb_ConfrmPassword" ErrorMessage="Please Fill the Confirm Password">*</asp:RequiredFieldValidator>
                                                                                                                         <asp:CompareValidator ID="cv_" runat="server" ControlToCompare="tb_password" ControlToValidate="tb_ConfrmPassword" ForeColor="Red" ErrorMessage="Password and Confirm password must be same">*</asp:CompareValidator>
                                                                                              </td>
                    </tr>
                     <tr>
                        <td></td><td style="border:1px solid Black;">Email Address</td><td style="border:1px solid Black;" class="TextBox">
                             <asp:TextBox ID="tb_EmailAddress" Width="200px" runat="server"></asp:TextBox>
                                                                                       </td><td>
                                                                                                                     
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" runat="server" ControlToValidate="tb_EmailAddress" ErrorMessage="Please Fill the Email Address">*</asp:RequiredFieldValidator>
                                                                                            </td>
                    </tr>
                     <tr>
                             <td></td><td style="border:1px solid Black">Role</td>
                                  <td style="border:1px solid Black" class="TextBox"><asp:DropDownList Width="200px" ID="dd_roleId" runat="server">
                                                                                <asp:ListItem Value="1" Text="Admin"></asp:ListItem>
                                                                                <asp:ListItem Value="2" Text="User"></asp:ListItem>
                                                                                </asp:DropDownList></td><td></td>
                    </tr>
                              <tr>
                        <td></td><td style="border:1px solid Black">Status</td>
                                  <td style="border:1px solid Black" class="TextBox"><asp:DropDownList Width="200px" ID="dd_status" runat="server">
                                                                                <asp:ListItem Value="1" Text="Active"></asp:ListItem>
                                                                                <asp:ListItem Value="0" Text="De-Active"></asp:ListItem>
                                                                                </asp:DropDownList></td><td></td>
                    </tr>
                                                  <tr>
                        <td></td><td colspan="2">
                            <asp:Label ID="lb_Message" runat="server" ForeColor="Red"></asp:Label>
                      <asp:ValidationSummary ForeColor="Red" ID="vs" runat="server" />
                                   
                                 </td><td></td>
                                                                                                   <tr style="height:50px">
                        <td></td><td align="right" colspan="2" style="padding-right:1em">
                            <asp:Button ID="btn_Submit" OnClick="btn_Submit_Click" Text="Submit" runat="server" Width="150" />
                            
                                 </td><td></td>
                    </tr>
                        
                </table>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>

        </tr>
        <tr style="height:100px"><td>&nbsp;</td></tr>
    </table>
    </div>
    </form>
</body>
</html>
