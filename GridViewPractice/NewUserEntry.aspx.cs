using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewUserEntry : System.Web.UI.Page
{
    DataTable dt_LastUserInformation = new DataTable();
    bool Password_Contains_Digits = false;
    DataTable dt_User_Already_Exist = new DataTable();
    DataTable dt_Email_Already_Exist = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FetchData();
            lb_userId.Text = dt_LastUserInformation.Rows[0]["userId"].ToString();
        }
    }

    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        try
        {
            validation();
        }
        catch (Exception ex)
        {
            lb_Message.Text = ex.Message + "<br/>" + ex.StackTrace;
            return;
        }
    }

    public void validation()
    {
        lb_Message.Text = string.Empty;
        Check_UserName_Already_Exist();
        Check_Email_Already_Exist();

        if (dt_User_Already_Exist.Rows.Count > 0)
        {
            lb_Message.Text = "Please Select Other UserName ( " + tb_UserName.Text + ") Already Used By Other User";
            return;
        }

        if (dt_Email_Already_Exist.Rows.Count > 0)
        {
            lb_Message.Text = "Please Select Other Email Address ( " + tb_EmailAddress.Text + ") Already Used By Other User";
            return;
        }

        if (!tb_EmailAddress.Text.Contains("@"))
        {
            lb_Message.Text = "Please Enter The Valid Email Address";
            return;
        }

        if (tb_UserName.Text.Count() < 5)
        {
            lb_Message.Text = "Please Enter UserName Consist of Atleast Five Characters";
            return;
        }

        if (Check_Password_Contails_Digits() == false)
        {
            lb_Message.Text = "Your Password Atleast Consist of One Digit";
            return;
        }

        if (tb_password.Text.Count() < 8)
        {
            lb_Message.Text = "Password Atleast Have Eight Character Long";
            return;
        }

        Data_Insert();
        lb_Message.Text = "Data is Submitted Successfully";
        lb_Message.ForeColor = System.Drawing.Color.Green;
    }

    public bool Check_Password_Contails_Digits()
    {
        Password_Contains_Digits = false;

        if (tb_password.Text.Contains("0"))
        {
            Password_Contains_Digits = true;
        }
        if (tb_password.Text.Contains("1"))
        {
            Password_Contains_Digits = true;
        }
        if (tb_password.Text.Contains("2"))
        {
            Password_Contains_Digits = true;
        }
        if (tb_password.Text.Contains("3"))
        {
            Password_Contains_Digits = true;
        }
        if (tb_password.Text.Contains("4"))
        {
            Password_Contains_Digits = true;
        }
        if (tb_password.Text.Contains("5"))
        {
            Password_Contains_Digits = true;
        }
        if (tb_password.Text.Contains("6"))
        {
            Password_Contains_Digits = true;
        }
        if (tb_password.Text.Contains("7"))
        {
            Password_Contains_Digits = true;
        }
        if (tb_password.Text.Contains("8"))
        {
            Password_Contains_Digits = true;
        }
        if (tb_password.Text.Contains("9"))
        {
            Password_Contains_Digits = true;
        }

        return Password_Contains_Digits;
    }

    public void FetchData()
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GridView_KudvankatConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand("GetLastUserInformation", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        con.Open();
        sda.Fill(dt_LastUserInformation);
        con.Close();
    }

    public void Data_Insert()
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GridView_KudvankatConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand("sp_UserEntry", con);
        cmd.CommandType = CommandType.StoredProcedure;
        //SqlDataAdapter sda = new SqlDataAdapter(cmd);
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

    private void Check_UserName_Already_Exist()
    {
        string sqlString = "select * from users where username = '" + tb_UserName.Text.Trim() + "'";
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GridView_KudvankatConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand(sqlString, con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        con.Open();
        sda.Fill(dt_User_Already_Exist);
        con.Close();
    }

    private void Check_Email_Already_Exist()
    {
        string sqlString = "select * from users where emailAddress = '" + tb_EmailAddress.Text.Trim() + "'";
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GridView_KudvankatConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand(sqlString, con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        con.Open();
        sda.Fill(dt_Email_Already_Exist);
        con.Close();
    }
}