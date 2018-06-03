using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Receive2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Control ctContent = PreviousPage.Controls[0].FindControl("ContentPlaceHolder1");
            var nameText = ctContent.FindControl("NameTextBox") as TextBox;
            NameLabel.Text = nameText.Text;
        }
    }
}