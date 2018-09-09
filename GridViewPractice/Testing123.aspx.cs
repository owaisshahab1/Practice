using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Testing123 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {



    }
    protected void btn1_Click(object sender, EventArgs e)
    {
       ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "successAlert();", true);
    }

    protected void btn2_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "notFoundAlert();", true);
        //ScriptManager.RegisterStartupScript()
    }

    protected void btn3_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "deleteAlert();", true);
        //ScriptManager.RegisterStartupScript()
    }



    protected void Button4_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "errorAlert();", true);
    }
}