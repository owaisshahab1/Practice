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
    public partial class UserDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetUserInfoData();
            }
        }

        private void GetUserInfoData()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbtest"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllUserInfo",conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    UserInfoRepeater.DataSource = reader;
                    UserInfoRepeater.DataBind();
                }
            }
        }
    }
}