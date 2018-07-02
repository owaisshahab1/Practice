using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Repeater : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            this.BindRepeater();

            // query for total by Category 
            //===========================================
            //           select CategoryName,Count(ProductName) as TotalProducts,sum(UnitPrice) as UnitPrice,sum(UnitsInStock) as UnitsInStock,sum(UnitsOnOrder) as UnitsOnOrder,sum(ReorderLevel) as ReOrderLevel

            //from Products p join Categories s on
            //p.CategoryID = s.CategoryID  group by CategoryName
            //===============================================
        }
    }

    private void BindRepeater()
    {
        string constr = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand(" select ProductName,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel from Products order by CategoryID", con))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    rptCustomers.DataSource = dt;
                    rptCustomers.DataBind();
                }
            }
        }
    }
}