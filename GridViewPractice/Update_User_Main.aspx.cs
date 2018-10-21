using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Update_User_Main : System.Web.UI.Page
{
    string html = string.Empty;
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            html = string.Empty;
            lt.Text = string.Empty;
            FillDataTable();
            if (dt.Rows.Count <= 0)
            {
                lb_message.Text = "Data Not Found 101";
                return;
            }
            htmlGenerator();
            lt.Text = html;
        }
}

    private void FillDataTable()
    {
        string sqlString = "select * from Users";
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GridView_KudvankatConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand(sqlString, con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        con.Open();
        sda.Fill(dt);
        con.Close();
    }

    private void htmlGenerator()
    {

        string sqlString = "<table border=\"1\" style=\"width:100%; border-collapse:collapse; padding:1px 1px 1px 1px\">\n" +
        "    <tr style=\"height:100px\"></tr>\n" +
        "    <tr>\n" +
        "        <th style=\"width:10%\">User Id</th>\n" +
        "        <th style=\"width:10%\">User Name</th>\n" +
        "        <th style=\"width:10%\">User Password</th>\n" +
        "        <th style=\"width:10%\">User Email Address</th>\n" +
                "        <th style=\"width:10%\">Status</th>\n" +
                        "        <th style=\"width:10%\">RoleId</th>\n" +
        "        <th style=\"width:10%\">User Date Created</th>\n" +
        "        <th style=\"width:10%\">User Date Modified</th>\n" +
        "    </tr>\n";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            DataRow dr = dt.Rows[i];
            sqlString += "    <tr>\n" +
            "        <td>"+dr["UserId"]+"</td>\n" +
            "        <td><a href=\"Update_User.aspx?UserId=" + dr["UserId"] + "&UserName=" + dr["UserName"] +
                    "&Password=" + dr["pass_word"] + "&EmailAddress=" + dr["emailAddress"] + "&Status=" + dr["status"] + "&RoleId=" + dr["RoleId"] +
                    "&EntryDate=" + dr["entryDate"] + "&ModifyDate=" + dr["modifyDate"] +"\" target=\"_blank\">" + dr["UserName"]+"</a></td>\n" +
            "        <td>" + dr["pass_word"] + "</td>\n" +
            "        <td>"+dr["emailAddress"]+"</td>\n" +
                        "        <td>" + dr["status"] + "</td>\n" +
                                    "        <td>" + dr["RoleId"] + "</td>\n" +
            "        <td>" +dr["entryDate"]+"</td>\n" +
            "        <td>"+dr["modifyDate"]+"</td>\n" +
            "\n" +
            "    </tr>\n"; 
        }
        sqlString += "    <tr style=\"height:100px\"></tr>\n" +
        "</table>";

        html += sqlString;

    }
}