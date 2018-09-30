using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SubTotal : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    DataTable dtNew = new DataTable();
    bool OnlyCallOnce = false;
    string html = string.Empty;
    string previousDate = string.Empty;
    string previousCompany = string.Empty;
    int[] DateWiseTotalArray = new int[5];

    protected void Page_Load(object sender, EventArgs e)
    {
        MakingDataTable();
        lt.Text = html;

        html += "<table width='100%' border='1' style='border-collapse:collapse'>";
        //html += "<tr><th>Date</th><th>Company</th><th>Name1</th><th>Name2</th><th>Name3</th><th>Name4</th></tr>";

        html += "<tr>";
        for (int i = 0; i < dt.Columns.Count; i++)
        {
            
            html += "<th>"+dt.Columns[i].ColumnName+"</th>";
        }
        html += "<th>Total</th></tr>";


        previousDate = dt.Rows[0]["Date"].ToString();
        previousCompany = dt.Rows[0]["Company"].ToString();

        for (int i = 0; i < dt.Rows.Count; i++)
        {

            DataRow drMain = dt.Rows[i];


            if (OnlyCallOnce)
            {
                if (previousDate == drMain["Date"] && previousCompany == drMain["Company"])
                {
                    continue;
                }
                else
                {
                    if (previousDate != dt.Rows[i]["Date"].ToString())
                    {
                        html += "<tr><td>"+previousDate+ "</td><td>" + previousCompany + "</td><td>" + DateWiseTotalArray[0] + "</td>"+
                            "<td>" + DateWiseTotalArray[1] + "</td><td>" + DateWiseTotalArray[2] + "</td><td>" + DateWiseTotalArray[3] + "</td>" +
                            "<td>" + DateWiseTotalArray[4] + "</td></tr>";

                        Array.Clear(DateWiseTotalArray, 0, DateWiseTotalArray.Length);
                    }

                    previousDate = dt.Rows[i]["Date"].ToString();
                    previousCompany = dt.Rows[i]["Company"].ToString();
                } 
            }

        DataRow[] drNew = dt.Select("Date = '" + previousDate + "' and Company = '" + previousCompany + "'");

        dtNew = drNew.CopyToDataTable();

        for (int j = 0; j < dtNew.Rows.Count; j++)
        {
            DataRow dr = dtNew.Rows[j];
            int horizontalTotal = 0;
            


            horizontalTotal = Convert.ToInt32( dr["Owais"]) + Convert.ToInt32(dr["Kafeel"]) + Convert.ToInt32(dr["Ahad"]) + Convert.ToInt32(dr["Jawad"]);

            html += "<tr><td>"+dr["Date"]+ "</td><td>"+dr["Company"]+ "</td><td>"+dr["Owais"]+"</td><td>"+dr["Kafeel"]+"</td><td>"+dr["Ahad"]+"</td><td>"+dr["Jawad"]+"</td><td>"+ horizontalTotal + "</td></tr>";
        }

            int companyWiseHorizontalTotal = Convert.ToInt32( dtNew.Compute("Sum(Owais)", "")) + Convert.ToInt32( dtNew.Compute("Sum(Kafeel)", "")) 
                                                            + Convert.ToInt32(dtNew.Compute("Sum(Ahad)", "")) + Convert.ToInt32(dtNew.Compute("Sum(Jawad)", ""));

            html += "<tr><td>" + previousDate + "</td><td>" + previousCompany + "</td><td>" + dtNew.Compute("Sum(Owais)", "") + "</td><td>" + dtNew.Compute("Sum(Kafeel)", "") + "</td>" +
                    "<td>" + dtNew.Compute("Sum(Ahad)", "") + "</td><td>" + dtNew.Compute("Sum(Jawad)", "") + "</td><td>"+companyWiseHorizontalTotal+"</td>";

            DateWiseTotalArray[0] += Convert.ToInt32(dtNew.Compute("Sum(Owais)", ""));
            DateWiseTotalArray[1] += Convert.ToInt32(dtNew.Compute("Sum(Kafeel)", ""));
            DateWiseTotalArray[2] += Convert.ToInt32(dtNew.Compute("Sum(Ahad)", ""));
            DateWiseTotalArray[3] += Convert.ToInt32(dtNew.Compute("Sum(Jawad)", ""));
            DateWiseTotalArray[4] += companyWiseHorizontalTotal;

            OnlyCallOnce = true;
        }

        html += "<tr><td>" + previousDate + "</td><td>" + previousCompany + "</td><td>" + DateWiseTotalArray[0] + "</td>" +
               "<td>" + DateWiseTotalArray[1] + "</td><td>" + DateWiseTotalArray[2] + "</td><td>" + DateWiseTotalArray[3] + "</td>" +
               "<td>" + DateWiseTotalArray[4] + "</td></tr>";

        lt.Text = html;
    }

    private void MakingDataTable()
    {
        dt.Columns.Add("Date", typeof(string));
        dt.Columns.Add("Company", typeof(string));
        dt.Columns.Add("Owais", typeof(Int32));
        dt.Columns.Add("Kafeel", typeof(Int32));
        dt.Columns.Add("Ahad", typeof(Int32));
        dt.Columns.Add("Jawad", typeof(Int32));
        dt.Rows.Add("20-09-2018", "IS", "1", "3", "4", "5");
        dt.Rows.Add("20-09-2018", "IS", "1", "3", "4", "5");
        dt.Rows.Add("20-09-2018", "IS", "1", "3", "4", "5");
        dt.Rows.Add("20-09-2018", "IS", "1", "3", "4", "5");
        dt.Rows.Add("20-09-2018", "IS", "1", "3", "4", "5");
        dt.Rows.Add("20-09-2018", "TP", "6", "7", "8", "9");
        dt.Rows.Add("20-09-2018", "TP", "6", "7", "8", "9");
        dt.Rows.Add("20-09-2018", "TP", "6", "7", "8", "9");
        dt.Rows.Add("20-09-2018", "TP", "6", "7", "8", "9");
        dt.Rows.Add("20-09-2018", "TP", "6", "7", "8", "9");
        dt.Rows.Add("21-09-2018", "IS", "7", "8", "9", "10");
        dt.Rows.Add("21-09-2018", "IS", "7", "8", "9", "10");
        dt.Rows.Add("21-09-2018", "IS", "7", "8", "9", "10");
        dt.Rows.Add("21-09-2018", "IS", "7", "8", "9", "10");
        dt.Rows.Add("21-09-2018", "TP", "11", "12", "13", "14");
        dt.Rows.Add("21-09-2018", "TP", "11", "12", "13", "14");
        dt.Rows.Add("21-09-2018", "TP", "11", "12", "13", "14");
        dt.Rows.Add("21-09-2018", "MN", "15", "16", "17", "18");
        dt.Rows.Add("21-09-2018", "MN", "15", "16", "17", "18");
        dt.Rows.Add("21-09-2018", "MN", "15", "16", "17", "18");
        dt.Rows.Add("21-09-2018", "MN", "15", "16", "17", "18");
    }
}