using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    string userName = string.Empty;
    string password = string.Empty;
    DataTable dtMain = new DataTable();
    string connectionStringMain = "GridView_KudvankatConnectionString";
    DataSet dsMain = new DataSet();
  




    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tb_userName.Text.Trim()))
        {
            userName = tb_userName.Text.Trim();
        }
        if (!string.IsNullOrEmpty(tb_password.Text.Trim()))
        {
            password = tb_password.Text.Trim();
        }

        if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
        {
            LogInMethod(); 
        }

    }

    public void LogInMethod()
    {
        //string query = "select userName,UserRole,status from users where UserName = '"+userName+"' and '"+password+"'";

        //dtMain = GetDataFromDataBase(query, connectionStringMain);

        //if (dtMain == null || dtMain.Rows.Count <= 0)
        //{
        //    lb_Message.Visible = true;
        //    lb_Message.Text += "No data found (1)";
        //    return;
        //}

        dsMain = Get_SP_UserCheckStatusNRole("[sp_CheckUserRoleNStutus]",userName,password);

        if (dsMain == null || dsMain.Tables.Count <= 0)
        {
            lb_Message.Visible = true;
            lb_Message.Text += "No data found (1)";
            return;
        }


        dtMain = dsMain.Tables["Table"];
        DataRow dr = dtMain.Rows[0];

        Session["RoleId"] = dr["RoleId"];
        //Session["RoleName"] = 

    }

    public DataSet Get_SP_Menus(string RoleId,string status)
    {
        DataSet dsInner = new DataSet();
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GridView_KudvankatConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand("", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        cmd.Parameters.Add(new SqlParameter("@role_id", RoleId));
        cmd.Parameters.Add(new SqlParameter("@status", status));
        con.Open();
        sda.Fill(dsInner);
        con.Close();

        return dsInner;
    }

    public DataSet Get_SP_UserCheckStatusNRole(string procedure_name,string userName,string password)
    {
        DataSet dsInner = new DataSet();
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GridView_KudvankatConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand(procedure_name, con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        cmd.Parameters.Add(new SqlParameter("@userName", userName));
        cmd.Parameters.Add(new SqlParameter("@password", password));
        con.Open();
        sda.Fill(dsInner);
        con.Close();
        
        return dsInner;
        //dsMain 
    }

    public DataTable GetDataFromDataBase(string query, string ConnectionString)
    {
        DataTable dt = new DataTable();
        string conStr = System.Configuration.ConfigurationManager.ConnectionStrings[""].ConnectionString;
        SqlConnection con = new SqlConnection(conStr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = query;
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        con.Open();
        sda.Fill(dt);
        con.Close();

        if (dt == null || dt.Rows.Count <= 0)
        {
            lb_Message.Visible = true;
            lb_Message.Text = "No Data Found (0)";
            return null;
        }

        return dt;
    }
}