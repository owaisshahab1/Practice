<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Testing123.aspx.cs" Inherits="Testing123" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Scripts/sweetalert.css" rel="stylesheet" />
    <script src="Scripts/sweetalert.js"></script>
        <script type="text/javascript">
            function successAlert() {
                swal({
                    title: 'Congratulations!',
                    text: 'Your message has been succesfully sent',
                    type: 'success'
                });
            }

            function errorAlert() {
                swal({
                    title: 'Error!',
                    text: 'Something is Wrong Contact to IT Support',
                    type: 'error'
                });
            }

            function notFoundAlert() {
                swal({
                    title: 'testing',
                    text: 'you message is here',
                    type: 'warning'
                });
            }

            function deleteAlert() {
                swal({
                    title: "Are you sure?",
                    text: "You will not be able to recover this imaginary   file!",
                    type: "warning",
                    showCancelButton: true,
                    confirmButtonColor: "red",
                    confirmButtonText: "Yes, delete it!",
                    cancelButtonText: "No, cancel plx!",
                    //closeOnConfirm: true,
                    //closeOnCancel: true
                },
                function (isConfirm) {
                    if (isConfirm) {
                        swal("Deleted!", "Your imaginary file has been deleted.", "success");
                    } else {
                        swal("Cancelled", "Your imaginary file is safe :)", "error");
                    }
                });
            }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btn1"  runat="server" Text="Save Data Succesfully" OnClick="btn1_Click" />
          <asp:Button ID="Button2" runat="server" Text="No Data Found" OnClick="btn2_Click" />
         <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="btn3_Click" />
        <asp:Button ID="Button4" runat="server" Text="Error" OnClick="Button4_Click" />
        <br />
        <a href="StockAgingReport.aspx" target="_blank"  onclick="">123</a>
        <asp:HyperLink  ID="abc123" NavigateUrl="~/StockAgingReport.aspx"  runat="server">455</asp:HyperLink>
    </div>
    </form>
</body>
</html>
