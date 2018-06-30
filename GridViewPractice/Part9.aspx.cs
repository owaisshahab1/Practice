using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class Part9 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Write(System.Threading.Thread.CurrentThread.CurrentCulture.ToString());

        //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-IN"); 

        //foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
        //{
        //    Response.Write(ci.Name + " => " + ci.DisplayName + "<br/>");
        //}

    }


    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            int salary = Convert.ToInt32(e.Row.Cells[2].Text);
            string countryCulture = e.Row.Cells[3].Text;

            string formatString = string.Format(new System.Globalization.CultureInfo(countryCulture), "{0:c}", salary);

            e.Row.Cells[2].Text = formatString;
        }
    }

    //protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.Header)
    //    {
    //        e.Row.Cells[3].Visible = false;
    //    }
    //    else if (e.Row.RowType == DataControlRowType.DataRow)
    //    {
    //        int salary = Convert.ToInt32(e.Row.Cells[2].Text);
    //        string countryCulture = e.Row.Cells[3].Text;

    //        e.Row.Cells[3].Visible = false;
    //        string formatString = string.Format(new System.Globalization.CultureInfo(countryCulture), "{0:c}", salary);

    //        e.Row.Cells[2].Text = formatString;
    //    }
    //}


    /*==============  PART 8 =================

    //protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.DataRow)
    //    {
    //        if (e.Row.Cells[3].Text == "US")
    //        {
    //            int salary = Convert.ToInt32(e.Row.Cells[2].Text);
    //            string formatString = string.Format(new System.Globalization.CultureInfo("en-US"), "{0:c}", salary);
    //            e.Row.Cells[2].Text = formatString;
    //        }
    //        else if (e.Row.Cells[3].Text == "India")
    //        {
    //            int salary = Convert.ToInt32(e.Row.Cells[2].Text);
    //            string formatString = string.Format(new System.Globalization.CultureInfo("en-IN"), "{0:c}", salary);
    //            e.Row.Cells[2].Text = formatString;
    //        }
    //        else if (e.Row.Cells[3].Text == "UK")
    //        {
    //            int salary = Convert.ToInt32(e.Row.Cells[2].Text);
    //            string formatString = string.Format(new System.Globalization.CultureInfo("en-UK"), "{0:c}", salary);
    //            e.Row.Cells[2].Text = formatString;
    //        }
    //    }
    }*/



}