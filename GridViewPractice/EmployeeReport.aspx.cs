using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.OracleClient;
using System.IO;

// author owais shahab
// created on 09-09-2018
// main objective : "Understand about bussiness report development"

public partial class EmployeeReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind_Department_DDL();
        }
    }

    public void Bind_Department_DDL()
    {
        
        
        //string str = str.
        string cn = System.Configuration.ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString;
        string query = "SELECT d.Name,d.DepartmentID FROM [HumanResources].[Department] d";
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(cn);
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter oda = new SqlDataAdapter(cmd);
        oda.Fill(dt);
        con.Close();
        if (dt.Rows.Count > 0)
        {
            ddl_Department.DataTextField = "Name";
            ddl_Department.DataValueField = "DepartmentID";
            ddl_Department.DataSource = dt.DefaultView;
            ddl_Department.DataBind();
        }
        ddl_Department.Items.Insert(0, new ListItem("ALL", ""));
    }

    public void Bind_Shift_DDL()
    {
        string query = "SELECT ShiftID, \n"
           + "       Name \n"
           + "  FROM [AdventureWorks].[HumanResources].[Shift]";
        string cn = System.Configuration.ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString;
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(cn);
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter oda = new SqlDataAdapter(cmd);
        oda.Fill(dt);
        con.Close();
        if (dt.Rows.Count > 0)
        {
            ddl_Shift.DataTextField = "Name";
            ddl_Shift.DataValueField = "ShiftID";
            ddl_Shift.DataSource = dt.DefaultView;
            ddl_Shift.DataBind();
        }
        ddl_Shift.Items.Insert(0, new ListItem("ALL", ""));
    }

    protected void ddl_Department_SelectedIndexChanged(object sender, EventArgs e)
    {
        string query = "SELECT c.FirstName + ' ' + c.LastName Name, \n"
           + "	   e.ManagerID \n"
           + "	   FROM (([HumanResources].[Employee] e \n"
           + "INNER JOIN [HumanResources].[EmployeeDepartmentHistory] edh ON edh.EmployeeID = e.EmployeeID ) \n"
           + "INNER JOIN [HumanResources].[Department] d ON d.DepartmentID = edh.DepartmentID) \n"
           + "INNER JOIN [Person].[Contact] c ON c.ContactID = e.EmployeeID \n"
           + "WHERE \n"
           + "d.DepartmentID = '"+ddl_Department.SelectedValue+"' ";
        string cn = System.Configuration.ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString;
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(cn);
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter oda = new SqlDataAdapter(cmd);
        oda.Fill(dt);
        con.Close();
        if (dt.Rows.Count > 0)
        {

            ddl_Manager.DataTextField = "Name";
            ddl_Manager.DataValueField = "ManagerID";
            ddl_Manager.DataSource = dt.DefaultView;
            ddl_Manager.DataBind();
        }
        ddl_Manager.Items.Insert(0, new ListItem("ALL", ""));
    }

    protected void ddl_Manager_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        string query = GetQuery();

        #region sql connection for datatable

        string cn = System.Configuration.ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString;
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(cn);
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter oda = new SqlDataAdapter(cmd);
        oda.Fill(dt);
        con.Close();

        #endregion

        gv.DataSource = dt;
        gv.DataBind();
        
    }

    private string GetQuery()
    {
        string sql = "SELECT e.EmployeeID, \n"
           + "		c.FirstName + ' ' + c.LastName [First Name], -- only work when gender check disable \n";

        if (cb_nic.Checked)
        {
            sql += "	   e.NationalIDNumber NIC, -- optional \n";
        }

        if (cb_hd.Checked)
        {
            sql += "	   e.HireDate [Hire Date], -- optional \n";
        }

        if (cb_slh.Checked)
        {
            sql += "	   e.SickLeaveHours [Sick Leave(hr)], -- optional \n";
        }

        if (cb_jd.Checked)
        {
            sql += "	   e.Title [Job Description] , -- optional \n";
        }

        if (cb_dob.Checked)
        {
            sql += "	   e.BirthDate DOB, -- optional \n";
        }

        if (cb_vh.Checked)
        {
            sql += "	   e.VacationHours [Vacation(hr)], -- optional \n";
        }

        if (cb_li.Checked)
        {
            sql += "	   e.LoginID, -- optional \n";
        }

        if (cb_shift.Checked)
        {
            sql += "	   s.Name [Shift Name], -- optional \n";
        }

        if (cb_deptName.Checked)
        {
            sql += "	   d.Name [Dept Name], \n";
        }

        //if (cb_email.Checked)
        //{
        //    sql += "		c.EmailAddress [Email Address] \n";
        //}

        sql +="    \n"
            + "    c.EmailAddress[Email Address] \n"
            + "	   FROM ((([HumanResources].[Employee] e  \n"
            + "	   INNER JOIN HumanResources.EmployeeDepartmentHistory edh ON edh.EmployeeID = e.EmployeeID) \n"
            + "	   INNER JOIN [HumanResources].[Shift] s ON s.ShiftID = edh.ShiftID) \n"
            + "	   INNER JOIN [HumanResources].[Department] d ON d.DepartmentID = edh.DepartmentID) \n"
            + "	   INNER JOIN [Person].[Contact] c ON e.EmployeeID = c.ContactID  \n";

        sql += "WHERE  \n"
            + "edh.EmployeeID = e.EmployeeID \n";

        if (!string.IsNullOrEmpty(tb_nic.Text.Trim()))
        {
            sql += "AND e.NationalIDNumber = '"+ tb_nic.Text.Trim() + "' \n";
        }

        if (!string.IsNullOrEmpty(tb_HD_To.Text.Trim()) && !string.IsNullOrEmpty(tb_HD_From.Text.Trim()))
        {
            sql += "AND e.HireDate BETWEEN '"+ tb_HD_To.Text.Trim() + " 00:00:00.000' AND '"+ tb_HD_From.Text.Trim() + " 00:00:00.000' \n";
        }

        if (!string.IsNullOrEmpty(tb_DOB_To.Text.Trim()) && !string.IsNullOrEmpty(tb_DOB_From.Text.Trim()))
        {
            sql += "AND e.BirthDate BETWEEN '" + tb_DOB_To.Text.Trim() + " 00:00:00.000' AND '" + tb_DOB_From.Text.Trim() + " 00:00:00.000' \n";
        }

        #region Gender
        if (rb_Male.Checked)
        {
            sql += "AND e.Gender = 'm' -- m = male and f = female \n";
        }
        if (rb_Female.Checked)
        {
            sql += "AND e.Gender = 'f' -- m = male and f = female \n";
        }
        #endregion


        #region Martial Status
        if (rb_Married.Checked)
        {
            sql += "AND e.MaritalStatus = 'm' -- s = single and m = married  \n";
        }
        if (rb_Single.Checked)
        {
            sql += "AND e.MaritalStatus = 's' -- s = single and m = married  \n";
        } 
        #endregion

        if (ddl_Shift.SelectedIndex != 0)
        {
            sql += "AND edh.ShiftID = '"+ ddl_Shift.SelectedValue.Trim() + "' -- shift id 1,2,3 respectively day,evening,night \n";
        }

        if (ddl_Department.SelectedIndex != 0)
        {
            sql += "AND d.DepartmentID = '"+ ddl_Department.SelectedValue.Trim() + "'";
        }     
             
        return sql;
    }
}