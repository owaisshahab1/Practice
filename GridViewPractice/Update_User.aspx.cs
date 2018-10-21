using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Update_User : System.Web.UI.Page
{
    DataTable dt = new DataTable();

    string ModifyDate = string.Empty;
    string EntryDate = string.Empty;
    string RoleId = string.Empty;
    string Status = string.Empty;
    string UserName = string.Empty;
    string UserId = string.Empty;
    string EmailAddress = string.Empty;
    string password = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UserId = Request.QueryString["UserId"];
            UserName = Request.QueryString["UserName"];
            password = Request.QueryString["Password"];
            RoleId = Request.QueryString["RoleId"];
            Status = Request.QueryString["Status"];
            EmailAddress = Request.QueryString["EmailAddress"];
            EntryDate = Request.QueryString["EntryDate"];
            ModifyDate = Request.QueryString["ModifyDate"];

            if (string.IsNullOrEmpty(UserId))
            {
                lb_Message.Text = "Data is Missing 01";
                    return;
            }
            if (string.IsNullOrEmpty(UserName))
            {
                lb_Message.Text = "Data is Missing 02";
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                lb_Message.Text = "Data is Missing 03";
                return;
            }
            if (string.IsNullOrEmpty(RoleId))
            {
                lb_Message.Text = "Data is Missing 04";
                return;
            }
            if (string.IsNullOrEmpty(Status))
            {
                lb_Message.Text = "Data is Missing 05";
                return;
            }
            if (string.IsNullOrEmpty(EmailAddress))
            {
                lb_Message.Text = "Data is Missing 06";
                return;
            }
            if (string.IsNullOrEmpty(EntryDate))
            {
                lb_Message.Text = "Data is Missing 07";
                return;
            }

            lb_userId.Text = UserId;
            tb_UserName.Text = UserName;
            tb_password.Text = password;
            tb_ConfrmPassword.Text = password;
            tb_EmailAddress.Text = EmailAddress;
            
        }
    }

    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        try
        {
            UpdateUserData();
            lb_Message.Text = "Your Data is Successfully Entered";
        }
        catch (Exception ex)
        {
            lb_Message.Text = ex.Message + "<br/>" + ex.StackTrace;
            return;
        }
    }

    private void UpdateUserData()
    {
 
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GridView_KudvankatConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand("[sp_UpdateUserData]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@userId", lb_userId.Text));
        cmd.Parameters.Add(new SqlParameter("@UserName", tb_UserName.Text.Trim()));
        cmd.Parameters.Add(new SqlParameter("@Password", tb_password.Text.Trim()));
        cmd.Parameters.Add(new SqlParameter("@status", dd_status.SelectedValue.ToString()));
        cmd.Parameters.Add(new SqlParameter("@roleId", dd_roleId.SelectedValue.ToString()));
        cmd.Parameters.Add(new SqlParameter("@email", tb_EmailAddress.Text.Trim()));
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}