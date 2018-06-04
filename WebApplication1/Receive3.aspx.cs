using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Receive3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Students student = (Students)Session["NewStudent"];
            NameLabel.Text = student.Name;
            DOBLabel.Text =  student.DOB.ToString();
        }
    }
}