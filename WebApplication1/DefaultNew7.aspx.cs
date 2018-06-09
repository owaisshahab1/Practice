using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DefaultNew7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbtest"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_InsertUserInfo",conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar, 50).Value = NameTextBox.Text;
                    cmd.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar, 50).Value = EmailTextBox.Text;
                    cmd.Parameters.Add("@GenderId", System.Data.SqlDbType.Int).Value = Gender();
                    cmd.Parameters.Add("@PersonalizedEmailAllowed", System.Data.SqlDbType.Bit).Value = PersonalizedEmailCheckBox.Checked ? 1 : 0;

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    Response.Redirect("~/UserDetails.aspx");
                }
            }
        }

        private int Gender()
        {
            int genderId = (int)UserGender.Male;
            if (FemaleRadioButton.Checked)
            {
                genderId = (int)UserGender.Female;
            }
            return genderId;
        }
    }
}