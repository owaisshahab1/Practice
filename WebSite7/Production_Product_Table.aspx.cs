using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Production_Product_Table : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    DataTable dtColor = new DataTable();
    DataTable dtSize = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            SqlConnection("select * from AdventureWorks.Production.Product");
            //----------
            GetColors();//----DropDown
                        //HowManyProductWannaSelect?--------TextBox
            GetSize();//------DropDown
                      //Weight();--------TextBox
                      //ProductModel();-----DropDown

            ListItem listColors = new ListItem("Select Colors", "-1");
            ddlColors.Items.Insert(0, listColors);
            ListItem listSize = new ListItem("Select Size", "-1");
            ddlSize.Items.Insert(0, listSize);
        }



    }

    public void GetSize()
    {
        //dtSize

        dtSize.Columns.Add("SizeId");
        dtSize.Columns.Add("SizeName");
        DataView dv = dt.DefaultView;
        dv.Sort = "Size ASC";
        var distinctValues = dv.ToTable().AsEnumerable()
                        .Select(row => new {
                            sizes = row.Field<string>("Size"),
                            //attribute2_name = row.Field<string>("attribute2_name")
                        })
                        .Distinct();


        int i = 0;

        foreach (var item in distinctValues)
        {
            dtSize.Rows.Add(i, string.IsNullOrEmpty(item.sizes) ? "N/A" : item.sizes);
            i++;
        }

        //ddlColors.SelectedIndex = -1;
        //ddlColors.Text = "Please Select Color";
        ddlSize.DataTextField = "SizeName";
        ddlSize.DataValueField = "SizeId";
        //cbColors.DisplayMember = "ColorsName";
        //cbColors.ValueMember = "ColorsId";
        ddlSize.DataSource = dtSize;
        ddlSize.DataBind();


    }

    public DataTable SqlConnection(string sqlString)
    {
        //DataTable dt = new DataTable();
        string conString = ConfigurationManager.ConnectionStrings["AdventureWorksConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand(sqlString, con))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                    Session["dt"] = dt;
                }
            }
        }
        return dt;
    }

    public void GetColors()
    {

        dtColor.Columns.Add("ColorsId");
        dtColor.Columns.Add("ColorsName");
        var distinctValues = dt.AsEnumerable()
                        .Select(row => new {
                            colors = row.Field<string>("Color"),
                            //attribute2_name = row.Field<string>("attribute2_name")
                        })
                        .Distinct();

        int i = 0;
        foreach (var item in distinctValues)
        {
            dtColor.Rows.Add(i, string.IsNullOrEmpty(item.colors) ? "N/A" : item.colors);
            i++;
        }
        //ddlColors.SelectedIndex = -1;
        //ddlColors.Text = "Please Select Color";
        ddlColors.DataTextField = "ColorsName";
        ddlColors.DataValueField = "ColorsId";
        //cbColors.DisplayMember = "ColorsName";
        //cbColors.ValueMember = "ColorsId";
        ddlColors.DataSource = dtColor;
        ddlColors.DataBind();

    }

    protected void ddlColors_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddlSize_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        //SqlString();
        dt = (DataTable)Session["dt"];
        //int sum = 0;


        ////foreach (DataRow dr in dt.Rows)
        ////{
        ////    foreach (DataColumn dc in dt.Columns)
        ////    {
        ////        sum += (int)dr[dc];
        ////    }
        ////}
        //DataRow[] dr = dt.Select("SafetyStockLevel = " + "1000");
        //DataTable dtN = new DataTable();
        //DataTable dtSpecificOrders = dt.Clone();
        //foreach (var item in dr)
        //{
        //    dtSpecificOrders.Rows.Add(item.ItemArray);
        //    //dtN.ImportRow(item);
        //}

        //DataRow row = dt.NewRow();
        //row["ProductID"] = 656234;
        //row["Name"] = "Owais";
        //row["ProductNumber"] = "Owais123123";
        //row["ProductNumber"] = "Color";
        ////row["workedhours"] = dt.Compute("Sum(workedhours)", "workedhours > 0");
        ////row["tfshours"] = oldDataTable.Compute("Sum(tfshours)", "tfshours > 0");
        //dt.Rows.Add(row);

        //object sumObject1;
        //object sumObject2;
        //object sumObject3;
        //object sumObject4;
        //object sumObject5;
        ////sumObject = dt.Compute("Sum(SafetyStockLevel)", "Color = Color");
        //sumObject1 = dt.Compute("Sum(SafetyStockLevel)", "");
        //sumObject2 = dt.Compute("Sum(SafetyStockLevel)", "");
        //sumObject3 = dt.Compute("Sum(SafetyStockLevel)", "");
        //sumObject4 = dt.Compute("Sum(SafetyStockLevel)", "");
        ////dt = SqlConnection(SqlString());
        ////dt.Columns.Remove("MakeFlag");
        ////dt.Columns.Remove("FinishedGoodsFlag");

        //dt.Rows.Add(0, "", "Total", 0,Convert.ToInt16(sumObject1),Convert.ToInt16(sumObject2),Convert.ToUInt16(sumObject3),Convert.ToInt16(sumObject4));

        //  var sum = dt.AsEnumerable().Sum(x => x.Field<Int16>(6));
        //  DataRow toInsert = dt.NewRow();
        //  toInsert[0] = 1;
        //  toInsert[1] = "coldata2";
        //  toInsert[2] = "coldata3";
        //  toInsert[3] = false;
        //  toInsert[4] = false;
        //  toInsert[5] = "coldata5";
        //  toInsert[6] = sum;
        //  // insert in the desired place
        //  dt.Rows.InsertAt(toInsert, dt.Rows.Count);

        //  var result = dt.Rows.Cast<DataRow>().ToLookup(r => r[0] as string).Aggregate(dt.Clone(),
        //(t, g) => t.Rows.Add(g.Key, g.Sum(r => (int)r[1]), g.Sum(r => (int)r[2])).Table);

        DataTable table = new DataTable();

        table.Columns.Add("colour", typeof(string));
        table.Columns.Add("sum1", typeof(int));
        table.Columns.Add("sum2", typeof(int));
        table.Columns.Add("sum3", typeof(int));


        table.Rows.Add("black", 2, 3, 5);
        table.Rows.Add("white", 2, 3, 5);
        table.Rows.Add("black", 2, 3, 5);
        table.Rows.Add("white", 2, 3, 5);

        table.Rows.Add("black", 2, 3, 5);
        table.Rows.Add("white", 2, 3, 5);
        table.Rows.Add("black", 2, 3, 5);
        table.Rows.Add("white", 2, 3, 5);

        table.Rows.Add("black", 2, 3, 5);
        table.Rows.Add("white", 2, 3, 5);
        table.Rows.Add("black", 2, 3, 5);
        table.Rows.Add("white", 2, 3, 5);

        table.Rows.Add("black", 2, 3, 5);
        table.Rows.Add("white", 2, 3, 5);
        table.Rows.Add("black", 2, 3, 5);
        table.Rows.Add("white", 2, 3, 5);

        DataTable NewTable = new DataTable();
        NewTable.Columns.Add("colour", typeof(string));
        NewTable.Columns.Add("sum1", typeof(int));
        NewTable.Columns.Add("sum2", typeof(int));
        NewTable.Columns.Add("sum3", typeof(int));

        string PreviousColor = string.Empty;
        string PresentColor = string.Empty;

        PreviousColor = table.Rows[0].ItemArray[0].ToString();

        foreach (var item in table.Rows)
        {
            PresentColor = ((System.Data.DataRow)item).ItemArray[0].ToString();
            if (PresentColor == PreviousColor)
            {
                PreviousColor = PresentColor;
                NewTable.Rows.Add(((System.Data.DataRow)item).ItemArray[0].ToString());
            }
        }

        //        var result = dt.Rows.Cast<DataRow>().ToLookup(r => r[5] as string).Aggregate(dt.Clone(),
        //(t, g) => t.Rows.Add(g.Key, g.Sum(r => (int)r[6]), g.Sum(r => (int)r[7]), g.Sum(r => (int)r[8])).Table);

        //        var result2 = dt.Rows.Cast<DataRow>().ToLookup(r => r[0] as string).Aggregate(table.Clone(),
        //(t, g) => t.Rows.Add(g.Key, g.Sum(r => (int)r[4]), g.Sum(r => (int)r[5]), g.Sum(r => (int)r[6])).Table);



        gvProduct.DataSource = dt;
        gvProduct.DataBind();



    }

    private string SqlString()
    {
        string sqlString = "\n" +
       "\n" +
       "\n" +
       "select ";
        if (!string.IsNullOrEmpty(tbRecordQuantity.Text))
        {
            sqlString += " top " + tbRecordQuantity.Text;
        }

        sqlString += " [ProductID]\n" +
        "    ,[Name]\n" +
        "    ,[ProductNumber]\n" +
        "    ,[MakeFlag]\n" +
        "    ,[FinishedGoodsFlag]\n" +
        "    ,[Color]\n" +
        "    ,[SafetyStockLevel]\n" +
        "    ,[ReorderPoint]\n" +
        "    ,[StandardCost]\n" +
        "    ,[ListPrice]\n" +
        "    ,[Size]\n" +
        "    ,[SizeUnitMeasureCode]\n" +
        "    ,[WeightUnitMeasureCode]\n" +
        "    ,[Weight]\n" +
        "    ,[DaysToManufacture]\n" +
        "    ,[ProductLine]\n" +
        "    ,[Class]\n" +
        "    ,[Style]\n" +
        "    ,[ProductSubcategoryID]\n" +
        "    ,[ProductModelID]\n" +
        "    ,[SellStartDate]\n" +
        "    ,[SellEndDate]\n" +
        "    ,[DiscontinuedDate]\n" +
        "    ,[rowguid]\n" +
        "    ,[ModifiedDate] from AdventureWorks.Production.Product ";
        if (!string.IsNullOrEmpty(ddlSize.SelectedItem.ToString()) && !ddlSize.SelectedItem.ToString().Contains("Select"))
        {
            sqlString += " where Size < '" + ddlSize.SelectedItem + "'";
        }
        if (!string.IsNullOrEmpty(ddlColors.SelectedItem.ToString()) && !ddlColors.SelectedItem.ToString().Contains("Select"))
        {
            sqlString += " and Color = '" + ddlColors.SelectedItem + "' order by ProductID";
        }


        return sqlString;
    }

    protected void ExcelBtn_Click(object sender, EventArgs e)
    {
        Response.ClearContent();
        Response.AppendHeader("content-disposition", "attachment; filename=ProductExcelSheet.xls");

        StringWriter stringWriter = new StringWriter();
        HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

        gvProduct.RenderControl(htmlTextWriter);
        Response.Write(stringWriter.ToString());
        Response.End();

    }

    public override void VerifyRenderingInServerForm(Control control)
    {

    }

}

