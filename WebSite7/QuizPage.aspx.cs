using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QuizPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataRow dr = (DataRow)Session["dr"];
        Label1.Text = dr.ItemArray[1].ToString();
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        string answer = txbx.Text;
        DataRow dr = (DataRow)Session["dr"];

        if (answer == dr.ItemArray[4].ToString().Trim())
        {
            Label2.Visible = true;
            Label2.Text = "Your Answer is Correct";
        }
        else
        {
            Label2.Visible = true;
            Label2.Text = "Your Answer is Wrong Please Try Again";
        }
    }
}