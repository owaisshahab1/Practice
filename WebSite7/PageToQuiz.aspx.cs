using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PageToQuiz : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int section = 2;
            DataTable dt = new DataTable();
            string conStr = ConfigurationManager.ConnectionStrings["NewDemoConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sqlString = "select * from NewDemo.dbo.Quizes where section = " + section + "Order by QuizId, Section";
            SqlCommand cmd = new SqlCommand(sqlString, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            Random r = new Random();
            int ran = r.Next(1,dt.Rows.Count + 1);
            DataRow dr = dt.Rows[ran-1];
            Session["dr"] = dr;
        }
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("QuizPage.aspx");
    }
}