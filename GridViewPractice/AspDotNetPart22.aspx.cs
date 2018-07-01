using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


public partial class AspDotNetPart22 : System.Web.UI.Page
{
    ProductDataAccessLayer pdal = new ProductDataAccessLayer();
    

    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {
            ddlCategories.DataSource = GetData("spGetCategories", null);
                ddlCategories.DataBind();

            ListItem liCategory = new ListItem("Select Category","-1");
            ddlCategories.Items.Insert(0, liCategory);

            ListItem liProduct = new ListItem("Select Product", "-1");
            ddlProducts.Items.Insert(0, liProduct);

            ddlProducts.Enabled = false;
        }
    }

    private DataSet GetData(string SPName, SqlParameter SPParameter)
    {
        string cs = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;

        SqlConnection con = new SqlConnection(cs);

        SqlDataAdapter da = new SqlDataAdapter(SPName, con);

        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        if (SPParameter != null)
        {
            da.SelectCommand.Parameters.Add(SPParameter);
        }

        DataSet ds = new DataSet();

        da.Fill(ds);

        return ds;

    }
    protected void ddlCategories_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCategories.SelectedIndex == 0)
        {
            ddlProducts.SelectedIndex = 0;
            ddlProducts.Enabled = false;
        }
        else
        {
            ddlProducts.Enabled = true;
            SqlParameter parameter = new SqlParameter("@CategoryId", ddlCategories.SelectedValue);
            DataSet ds = GetData("spGetProductsByCategoryId", parameter);

            ddlProducts.DataSource = ds;
            ddlProducts.DataBind();
            

            ListItem liProduct = new ListItem("Select Product", "-1");
            ddlProducts.Items.Insert(0, liProduct);

            ddlProducts.SelectedIndex = 0;
            ddlProducts.Enabled = true;
        }
    }
    protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
    {

        //==========================TO DO=====================================

        if (ddlProducts.SelectedIndex > 0 && ddlProducts.SelectedValue != null)
        {
            Initializer v = new Initializer();


            string query = "select * from products where ProductID= \'"+ ddlProducts.SelectedValue +"'";

            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(v.strConnection());
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter oda = new SqlDataAdapter(cmd);
                oda.Fill(ds);
                DataTable dt = ds.Tables[0];
                GridView1.DataSource = dt;
                GridView1.DataBind();
                con.Close();
            }
            catch (Exception Err)
            { }
            finally
            { }

 

        }
    }
}