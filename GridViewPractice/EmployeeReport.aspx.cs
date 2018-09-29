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
using System.Drawing;

// author owais shahab
// created on 09-09-2018
// main objective : "Understand about bussiness report development"
// Todo list
// 1.sub total by shift
// 2.sub total by dept name
// 3.


public partial class EmployeeReport : System.Web.UI.Page
{
    bool ColumnSickLeavePresent = false;
    bool ColumnVacationPresent = false;
    int IndexColumnSickLeavePresent = 0;
    int IndexColumnVacationPresent = 0;
    DataTable dt = new DataTable();
    string StrLiteral = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind_Department_DDL();
            Bind_Shift_DDL();

        }
    }

    #region Events

    protected void gv_DataBound(object sender, EventArgs e)
    {
        #region Opening This Code Remove Buttom Lines in Excel ( e.g grand total )
        //GridViewRow row = new GridViewRow(0, -1, DataControlRowType.Header, DataControlRowState.Normal);
        //TableCell headerRow = new TableHeaderCell();
        //headerRow.Attributes.Add("Style", "font-style:8pt;font-style:sans-serif;");
        //int colCountRow = gv.Rows[0].Cells.Count;
        //headerRow.ColumnSpan = colCountRow;
        //headerRow.BackColor = Color.FromName("#1197F4");
        //headerRow.ForeColor = Color.White;
        //headerRow.Text = "ABC Private Limited";
        //row.Cells.Add(headerRow);
        //Table tableRow = gv.Controls[0] as Table;

        //if (tableRow != null)
        //{
        //    tableRow.Rows.AddAt(0, row);
        //} 
        #endregion Opening This Code Remove Buttom Lines in Excel ( e.g grand total )

    }

    private void HtmlSelectionFilterDraw()
    {
        if (gv != null)
        {
            lbl_TableHtml.Text = string.Empty;
            if (cb_grandTotal.Checked)
            {
                lbl_TableHtml.Text += "<table border='1' width='25%'><tr><td style=\"background-color:#0094ff; color:black;\">Grand Total Checked</td><td colspan='10' style=\"background-color:#0094ff; color:black;\">" + cb_grandTotal.Checked + "</td></tr>";
            }
            if (cb_dob.Checked)
            {
                lbl_TableHtml.Text += "<tr><td style=\"background-color:#0094ff; color:black;\">Date Of Birth Checked</td><td style=\"background-color:#0094ff; color:black;\">" + cb_dob.Checked + "</td></tr>";
            }
            if (cb_li.Checked)
            {
                lbl_TableHtml.Text += "<tr><td style=\"background-color:#0094ff; color:black;\">Login ID Checked</td><td style=\"background-color:#0094ff; color:black;\">" + cb_li.Checked + "</td></tr>";

            }
            if (cb_hd.Checked)
            {
                lbl_TableHtml.Text += "<tr><td style=\"background-color:#0094ff; color:black;\">Hire Date Checked</td><td style=\"background-color:#0094ff; color:black;\">" + cb_hd.Checked + "</td></tr>";
            }
            if (cb_jd.Checked)
            {
                lbl_TableHtml.Text += "<tr><td style=\"background-color:#0094ff; color:black;\">Job Description Checked</td><td style=\"background-color:#0094ff; color:black;\">" + cb_jd.Checked + "</td></tr>";
            }
            if (cb_nic.Checked)
            {
                lbl_TableHtml.Text += "<tr><td style=\"background-color:#0094ff; color:black;\">NIC Checked</td>" +
                                 "<td style=\"background-color:#0094ff; color:black;\">" + cb_nic.Checked + "</td></tr>";
            }

            if (ddl_Department.SelectedIndex != 0)
            {
                lbl_TableHtml.Text += "<tr><td style=\"background-color:#0094ff; color:black;\">Department: </td>" +
                                 "<td style=\"background-color:#0094ff; color:black;\">" + ddl_Department.SelectedItem.Text + "</td></tr>";
            }
            if (ddl_Shift.SelectedIndex != 0)
            {
                lbl_TableHtml.Text += "<tr><td style=\"background-color:#0094ff; color:black;\">Shift: </td>" +
                                 "<td style=\"background-color:#0094ff; color:black;\">" + ddl_Shift.SelectedItem.Text + "</td></tr>";
            }
            if (ddl_Manager.SelectedIndex != 0)
            {
                lbl_TableHtml.Text += "<tr><td style=\"background-color:#0094ff; color:black;\">Manager: </td>" +
                                 "<td style=\"background-color:#0094ff; color:black;\">" + ddl_Manager.SelectedItem.Text + "</td></tr>";
            }
            if (cb_shift.Checked)
            {
                lbl_TableHtml.Text += "<tr><td style=\"background-color:#0094ff; color:black;\">Shift Checked</td>" +
                                 "<td style=\"background-color:#0094ff; color:black;\">" + cb_shift.Checked + "</td></tr></table>";
            }
            //if (ddl_Department.SelectedIndex != 0)
            //{
            //    lbl_TableHtml.Text += "<tr><td style=\"background-color:#0094ff; color:black;\">Department: </td>" +
            //                     "<td style=\"background-color:#0094ff; color:black;\">" + ddl_Department.SelectedItem.Text + "</td></tr></table>";
            //}
        }
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            for (int i = 0; i < e.Row.Cells.Count; i++)
            {
                if (e.Row.Cells[i].Text.Contains("Sick"))
                {
                    IndexColumnSickLeavePresent = i;
                    ColumnSickLeavePresent = true;
                }

                if (e.Row.Cells[i].Text.Contains("Vacation"))
                {
                    IndexColumnVacationPresent = i;
                    ColumnVacationPresent = true;
                }
            }
        }

        if (e.Row.RowType == DataControlRowType.Header)
        {
            for (int i = 0; i < e.Row.Cells.Count; i++)
            {
                e.Row.Cells[i].BackColor = Color.FromName("#1197F4");
                e.Row.Cells[i].ForeColor = Color.Black;
            }
        }

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (ColumnSickLeavePresent == true)
            {
                e.Row.Cells[IndexColumnSickLeavePresent].HorizontalAlign = HorizontalAlign.Right;
            }
            if (ColumnVacationPresent == true)
            {
                e.Row.Cells[IndexColumnVacationPresent].HorizontalAlign = HorizontalAlign.Right;
            }
            if (e.Row.Cells[1].Text.Contains("Grand Total"))
            {
                for (int i = 0; i < e.Row.Cells.Count; i++)
                {
                    e.Row.Cells[i].BackColor = Color.FromName("#1197F4");
                    e.Row.Cells[i].ForeColor = Color.Black;
                }
            }
            if (e.Row.Cells[1].Text.Contains("Sub Total"))
            {
                for (int i = 0; i < e.Row.Cells.Count; i++)
                {
                    e.Row.Cells[i].BackColor = Color.Orange;
                    e.Row.Cells[i].ForeColor = Color.Black;
                }
            }
        }
    }

    protected void btn_ExcelExport_Click(object sender, EventArgs e)
    {
        Response.Clear();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment;filename=Employee_Report" + DateTime.Now.ToString() + ".xls");
        Response.Charset = "";
        Response.ContentType = "application/vnd.ms-excel";

        using (StringWriter sw = new StringWriter())
        {
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            if (gv.Rows.Count > 0)
            {
                gv.AllowPaging = false;
                tb123.RenderControl(htw);
            }

            string style = @"<style>.textmode{}</style>";
            Response.Write(style);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }

    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        // wrong way
        // refresh page to remove old data from display
        //Page.Response.Redirect(Page.Request.Url.ToString(), true);

        string query = GetQuery();


        #region sql connection for datatable
        try
        {
            string cn = System.Configuration.ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString;
            SqlConnection con = new SqlConnection(cn);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter oda = new SqlDataAdapter(cmd);
            oda.Fill(dt);
            con.Close();
        }
        catch (Exception ex)
        {
            lb_Message.Text = string.Empty;
            lb_Message.Text += "<br /><table width='100%'><tr>\n" +
           "    <td style=\"font-size:35px; font-family:'Times New Roman'; font-weight:bold; text-align:center\">Sorry there is Some Problem</td></tr>\n" +
           "<tr><td style=\"font-size:35px; font-family:'Times New Roman'; font-weight:bold; text-align:left\">Error: "+ex.Message+"</td></tr>"+
           "<tr><td>"+ex.StackTrace+"</td></tr></table>";
            return;
        }
        

        if (dt == null || dt.Rows.Count == 0)
        {
            lb_Message.Text = string.Empty;
            lb_Message.Text += "<br /><table width='100%'><tr>\n" +
            "    <td style=\"font-size:35px; font-family:'Times New Roman'; font-weight:bold; text-align:center\">Sorry</td></tr>\n" +
            "<tr><td style=\"font-size:35px; font-family:'Times New Roman'; font-weight:bold; text-align:center\">No Data Found</td></tr></table>";
            return;

        }

        #endregion sql connection for datatable

        if (cb_shift.Checked && cb_ShiftwiseTotal.Checked)
        {
            DataRow[] foundRowsDay = dt.Select("[Shift Name] = 'Day'");
            DataTable dtDay = new DataTable();
            dtDay = foundRowsDay.CopyToDataTable();

            DataRow dr = dtDay.NewRow();
            dr["First Name"] = "Sub Total";
            dr["Vacation(hr)"] = dtDay.Compute("Sum([Vacation(hr)])", "").ToString();
            dr["Sick Leave(hr)"] = dtDay.Compute("Sum([Sick Leave(hr)])", "").ToString();
            dtDay.Rows.Add(dr);

            DataRow[] foundRowsNight = dt.Select("[Shift Name] = 'Night'");
            DataTable dtNight = new DataTable();
            dtNight = foundRowsNight.CopyToDataTable();

            DataRow dr2 = dtNight.NewRow();
            dr2["First Name"] = "Sub Total";
            dr2["Vacation(hr)"] = dtNight.Compute("Sum([Vacation(hr)])", "").ToString();
            dr2["Sick Leave(hr)"] = dtNight.Compute("Sum([Sick Leave(hr)])", "").ToString();
            dtNight.Rows.Add(dr2);

            DataRow[] foundRowsEvening = dt.Select("[Shift Name] = 'Evening'");
            DataTable dtEvening = new DataTable();
            dtEvening = foundRowsEvening.CopyToDataTable();

            DataRow dr3 = dtEvening.NewRow();
            dr3["First Name"] = "Sub Total";
            dr3["Vacation(hr)"] = dtEvening.Compute("Sum([Vacation(hr)])", "").ToString();
            dr3["Sick Leave(hr)"] = dtEvening.Compute("Sum([Sick Leave(hr)])", "").ToString();
            dtEvening.Rows.Add(dr3);

            dt = new DataTable();

            dt = dtDay.Copy();
            dt.Merge(dtEvening);
            dt.Merge(dtNight);

            // todo
            // Grand total work must do here because if not calculated here then grand total calculation mixed with sub toal 
            //  and result of grand total is too much high because of addition of sub total values.
        }

        HtmlSelectionFilterDraw();

        if (rb_ResponsWrite.Checked)
        {
            TableHtmlLiteralDraw();

            // Removing OLD data from Display
            gv.DataSource = null;
            gv.DataBind();
        }

        if (rb_literal.Checked)
        {
            TableHtmlLiteralDraw();

            // Removing OLD data from Display
            gv.DataSource = null;
            gv.DataBind();
        }

        if (cb_grandTotal.Checked && rb_gv.Checked)
        {
            GrandTotal(dt);
        }

        // add new row in datatable in specific place
        //DataRow dr = dt.NewRow();
        //dt.Rows.InsertAt(dr, 0);


        if (rb_Repeater.Checked)
        {
            rp.DataSource = dt;
            rp.DataBind();
        }

        if (rb_gv.Checked)
        {
            gv.DataSource = dt;
            gv.DataBind();

        }
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
           + "d.DepartmentID = '" + ddl_Department.SelectedValue + "' ";
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
    #endregion Events

    #region Methods
    public void TableHtmlLiteralDraw()
    {
        StrLiteral = string.Empty;
        StrLiteral += "<table width='100%' border='1' style='border-collapse:collapse'>\n";
        StrLiteral += "    <tr>\n";
        for (int i = 0; i < dt.Columns.Count; i++)
        {
            StrLiteral += " <th style=\"color:black; background-color:chartreuse\">" + dt.Columns[i].ColumnName + "</th>\n";
        }
        StrLiteral += " </tr>\n";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            StrLiteral += "    <tr>\n";
            for (int j = 0; j < dt.Rows[i].ItemArray.Length; j++)
            {
                StrLiteral += "        <td style=\"text-align:right;\">" + dt.Rows[i].ItemArray[j] + "</td>\n";
            }
            StrLiteral += "    </tr>\n";
        }

        StrLiteral += "</table>";

        if (rb_literal.Checked)
        {
            lbl_TableHtml.Text += StrLiteral; 
        }
        else if (rb_ResponsWrite.Checked)
        {
            Response.Write(StrLiteral);
        }
    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
           server control at run time. */
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
            sql += "	   FORMAT(e.HireDate,'dd/MM/yyyy') [Hire Date], -- optional \n";
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
            sql += "	   FORMAT(e.BirthDate,'dd/MM/yyyy') DOB, -- optional \n";
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

        sql += "    \n"
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
            sql += "AND e.NationalIDNumber = '" + tb_nic.Text.Trim() + "' \n";
        }

        if (!string.IsNullOrEmpty(tb_HD_To.Text.Trim()) && !string.IsNullOrEmpty(tb_HD_From.Text.Trim()))
        {
            sql += "AND e.HireDate BETWEEN '" + tb_HD_To.Text.Trim() + " 00:00:00.000' AND '" + tb_HD_From.Text.Trim() + " 00:00:00.000' \n";
        }

        //CONVERT(VARCHAR,@your_date_Value,103)
        if (!string.IsNullOrEmpty(tb_DOB_To.Text.Trim()) && !string.IsNullOrEmpty(tb_DOB_From.Text.Trim()))
        {
            sql += "AND e.BirthDate BETWEEN CONVERT(DATE,'" + tb_DOB_To.Text.Trim() + "',103) AND CONVERT(DATE,'" + tb_DOB_From.Text.Trim() + "',103) \n";
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
            sql += "AND edh.ShiftID = '" + ddl_Shift.SelectedValue.Trim() + "' -- shift id 1,2,3 respectively day,evening,night \n";
        }

        if (ddl_Department.SelectedIndex != 0)
        {
            sql += "AND d.DepartmentID = '" + ddl_Department.SelectedValue.Trim() + "'";
        }

        return sql;
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

    public void GrandTotal(DataTable dt)
    {
        DataRow dr = dt.NewRow();
        //dr["EmployeeID"] = dt.Compute("Count([EmployeeID])", "").ToString(); // count employees
        dr["First Name"] = "Grand Total";
        dr["Vacation(hr)"] = dt.Compute("Sum([Vacation(hr)])", "").ToString();
        dr["Sick Leave(hr)"] = dt.Compute("Sum([Sick Leave(hr)])", "").ToString();
        // dr["Sick Leave(hr)"] = dt.Compute("Vacation(hr)", "");
        dt.Rows.Add(dr);
    }
    #endregion Methods




}