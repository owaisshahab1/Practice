using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class ComplexChartVc4 : Form
    {
        public ComplexChartVc4()
        {
            InitializeComponent();
        }

        private void ComplexChartVc4_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            //chart1.DataSource = GetData();
            //chart1.Series["Series1"].XValueMember = "Year";
            //chart1.Series["Series1"].YValueMembers = "Total";
            chart1.DataBindCrossTable(GetData().DefaultView, "Registration Type", "Year", "Total","Label=Total");

        }

        private DataTable GetData()
        {
            DataTable dtChartData = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbx"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_chartData4", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtChartData.Load(reader);
                }
            }
            return dtChartData;
        }
    }
}
