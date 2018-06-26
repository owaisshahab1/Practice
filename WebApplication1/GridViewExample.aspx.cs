using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class GridViewExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = GridView1.SelectedRow;

            TextBox1.Text = gr.Cells[1].Text;
            TextBox2.Text = gr.Cells[2].Text;
            TextBox3.Text = gr.Cells[3].Text;
            TextBox4.Text = gr.Cells[4].Text;
        }
    }
}