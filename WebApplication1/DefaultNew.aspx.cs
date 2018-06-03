using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DefaultNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GenderCustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //if (MaleRadioButton.Checked || FemaleRadioButton.Checked)
            //{
            //    args.IsValid = true;
            //}
            //else
            //{
            //    args.IsValid = false;
            //}
            args.IsValid = MaleRadioButton.Checked || FemaleRadioButton.Checked ? true : false;
        }
    }
}