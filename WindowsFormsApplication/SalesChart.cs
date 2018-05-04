using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication
{
    public partial class SalesChart : Form
    {
        //125.C# Chart Tutorial In Urdu - Basics (Sales By Year Chart) - YouTube


        public SalesChart()
        {
            InitializeComponent();
        }


        private void SalesChart_Load(object sender, EventArgs e)
        {
            SalesByYearChart.DataSource = GetData();
            SalesByYearChart.Series["SalesByYear"].XValueMember = "Year"; 
            SalesByYearChart.Series["SalesByYear"].YValueMembers = "Total";
        }

        private DataTable GetData()
        {
            DataTable dtData = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbx"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_ChartData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtData.Load(reader);
                }

            }
            return dtData;
        }
    }
}
