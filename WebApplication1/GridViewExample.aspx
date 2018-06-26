<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewExample.aspx.cs" Inherits="WebApplication1.GridViewExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 56%;
        }
        .auto-style2 {
            width: 633px;
        }
        .auto-style3 {
            width: 546px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Hiriti Study Hub"></asp:Label>
    <div>
    
        <br />
        Show Data of Selected Row in GridView into TextBoxes in Asp.Net<br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="rollno" HeaderText="Roll No" SortExpression="rollno" />
                <asp:BoundField DataField="sName" HeaderText="Student Name" SortExpression="sName" />
                <asp:BoundField DataField="fName" HeaderText="Father Name" SortExpression="fName" />
                <asp:BoundField DataField="city" HeaderText="City" SortExpression="city" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HiritiStudyHubConnectionString %>" SelectCommand="SELECT * FROM [StudentInfo]"></asp:SqlDataSource>
        <br />
        Select Row Data Given Below :<br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Roll No:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Student Name :</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Father Name :</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">City :</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox4" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
