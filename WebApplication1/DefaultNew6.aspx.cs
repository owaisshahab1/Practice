using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DefaultNew6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie httpCookie = Request.Cookies["UserInfo"];

            if (httpCookie == null)
            {
                txtDiv.Visible = true;
            }
            else
            {
                msgDiv.Visible = true;

                string userName = httpCookie.Values["Name"].ToString();
                WelcomeLabel.Text = "Welcome back " + userName;
            }
        }

        protected void SignUpButton_Click(object sender, EventArgs e)
        {
            HttpCookie httpCookie = new HttpCookie("UserInfo");
            httpCookie.Values.Add("Name", NameTextBox.Text);
            httpCookie.Expires = DateTime.Now.AddDays(1);

            Response.Cookies.Add(httpCookie);
            Response.Redirect("Thanks.aspx?name" + NameTextBox.Text);
        }
    }
}