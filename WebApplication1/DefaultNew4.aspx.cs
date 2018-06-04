using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DefaultNew4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void NextPageButton_Click(object sender, EventArgs e)
        {
            Students student = new Students()
            {
                Name = NameTextBox.Text,
                DOB = DateTime.Parse(DOBTextBox.Text)
            };

            Session["NewStudent"] = student;

            Response.Redirect("Receive3.aspx");
        }
    }
}