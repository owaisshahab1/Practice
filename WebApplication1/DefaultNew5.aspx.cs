using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DefaultNew5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void NextPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Receive4.aspx?firstName=" + FirstNameTextBox.Text + "&lastName=" + LastNameTextBox.Text);
        }
    }
}