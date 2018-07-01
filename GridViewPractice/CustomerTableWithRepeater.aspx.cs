using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class CustomerTableWithRepeater : System.Web.UI.Page
{
    string queryString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string queryString = " Select distinct Country from Customers";
            ddlCountry.DataSource = GetData(queryString,null);
            ddlCountry.DataBind();
        }
    }

    private DataTable GetData(string queryString, String selectedValue)
    {
        string cs = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;

        SqlConnection con = new SqlConnection(cs);

        //SqlDataAdapter da = new SqlDataAdapter(queryString, con);

        SqlCommand cmd = new SqlCommand(queryString, con);

        cmd.CommandType = CommandType.Text;

        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();

        da.Fill(ds);

        DataTable dt = ds.Tables[0];
        

        DataTable dt2 = new DataTable() ;
        dt2.Columns.Add("CountryName", typeof(string));
        dt2.Columns.Add("CountryId", typeof(int));
        for (int i = 1; i < dt.Rows.Count+1; i++)
        {
            dt2.Rows.Add(dt.Rows[i-1].ItemArray[0].ToString(),i);
        }
        Session["CountryTable"] = dt2;
        return dt2;
    }





    protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCountry.SelectedIndex == 0)
        {
            ddlCity.SelectedIndex = 0;
            ddlCity.Enabled = false;
        }
        else
        {
            ddlCity.Enabled = true;

            DataTable countryIdToName = (DataTable)Session["CountryTable"];

            var results = from myRow in countryIdToName.AsEnumerable()
                          where myRow.Field<String>("CountryId") == ddlCountry.SelectedValue
                          select myRow;


            queryString = "Select distinct City from Customers where country =  \'" + ddlCountry.SelectedItem + "\' order by City asc";

            string cs = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            //SqlDataAdapter da = new SqlDataAdapter(queryString, con);

            SqlCommand cmd = new SqlCommand(queryString, con);

            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //DataSet ds = new DataSet();

            DataTable dt = new DataTable();

            da.Fill(dt);
            con.Close();

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("CityName", typeof(string));
            dt2.Columns.Add("CityId", typeof(int));
            for (int i = 1; i < dt.Rows.Count + 1; i++)
            {
                dt2.Rows.Add(dt.Rows[i - 1].ItemArray[0].ToString(), i);
            }
            Session["CityTable"] = dt2;

            ddlCity.DataSource = dt2;
            ddlCity.DataBind();

            //SqlParameter parameter = new SqlParameter("@CategoryId", ddlCategories.SelectedValue);
            //DataSet ds = GetData("spGetProductsByCategoryId", parameter);

            //ddlProducts.DataSource = ds;
            //ddlProducts.DataBind();
        }
    }
}