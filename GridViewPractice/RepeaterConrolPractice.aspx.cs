using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.OracleClient;

public partial class RepeaterConrolPractice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string cn = "ConnectionString_local";
        string qs = "select * from employees";
        OracleConnection con2 = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings[cn].ConnectionString);

        //    OracleConnection con2 = new OracleConnection();
        //    con2.ConnectionString = "User Id=sys;Password=sys;" +
        //"DBA Privilege=SYSDBA;Data Source=orcl;";

        OracleCommand cmd2 = new OracleCommand();
        cmd2.Connection = con2;
        cmd2.CommandText = qs;
        cmd2.CommandType = CommandType.Text;
        DataTable dt = new DataTable();
        OracleDataAdapter adapter = new OracleDataAdapter(cmd2);
        con2.Open();
        adapter.Fill(dt);
        con2.Close();



        if (!IsPostBack)
        {
            
        }

        Initializer v = new Initializer();


        //string query = "select * from products where ProductID= \'" + ddlProducts.SelectedValue + "'";

        string query = "select * from products";

        DataSet ds = new DataSet();
        try
        {
            SqlConnection con = new SqlConnection(v.strConnection());
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter oda = new SqlDataAdapter(cmd);
            oda.Fill(ds);
            //DataTable dt = ds.Tables[0];
            //Repeater1.DataSource = dt;
            Repeater1.DataBind();
            con.Close();
        }
        catch (Exception Err)
        { }
        finally
        { }
    }

}

public class testing
{
    
    public static DataTable GetTableFromDatabase(string query, string cn)
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(cn);
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter oda = new SqlDataAdapter(cmd);
        oda.Fill(dt);
        con.Close();
        return dt;
    }
}