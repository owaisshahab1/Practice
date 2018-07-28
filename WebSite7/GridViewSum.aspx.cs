using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GridViewSum : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int[] sumIdArray = new int[3];

        string constr = ConfigurationManager.ConnectionStrings["NewDemoConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("select * from CustomersNew", con))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //sumIdArray[i] += String.IsNullOrEmpty(dt.Rows[i].ItemArray[0].ToString()) ? 0 : Convert.ToInt32(dt.Rows[i].ItemArray[0]);
                        //sumIdArray[i] += String.IsNullOrEmpty(dt.Rows[i].ItemArray[0].ToString()) ? 0 : Convert.ToInt32(dt.Rows[i].ItemArray[7]);

                    }

                    dt.Rows.Add(sumIdArray[0].ToString(), "", "", "", "", "", "", sumIdArray[1].ToString());

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
        }
    }
}