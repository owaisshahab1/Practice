using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class ChartDemoVc3 : Form
    {
        public ChartDemoVc3()
        {
            InitializeComponent();
        }

        private void ChartDemoVc3_Load(object sender, EventArgs e)
        {
            FromcomboBox.Text = "2013";
            TocomboBox.Text = "2015";
            LoadGraphData();
        }

        private DataTable GetData()
        {
            DataTable dtData = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbx"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_ChartData2", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@FromYear", FromcomboBox.Text);
                    cmd.Parameters.AddWithValue("@ToYear", TocomboBox.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtData.Load(reader);
                }
            }
            return dtData;
        }

        private void PolulatingTable()
        {

            //// inserting data into table one time only
            ///*{  int length = 2023;
            //int id = 9;
            //Random rnd = new Random();


            //for (int i = 1991; i < length; i++)
            //{
            //    int rnd1 = rnd.Next(100, 1000);
            //    id++;
            //    // DataTable dtData = new DataTable();
            //    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbx"].ConnectionString))
            //    {
            //        using (SqlCommand cmd = new SqlCommand("usp_InsertData", conn))
            //        {
            //            cmd.CommandType = CommandType.StoredProcedure;

            //            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            //            cmd.Parameters.Add("@total", SqlDbType.Int).Value = rnd1;
            //            cmd.Parameters.Add("@Date", SqlDbType.VarChar).Value = i.ToString();

            //            conn.Open();
            //            cmd.ExecuteNonQuery();

            //            //conn.Open();
            //            //SqlDataReader reader = cmd.ExecuteReader();
            //            //dtData.Load(reader);
            //        }

            //    }
            //}*/
        }

        private void OkayBtn_Click(object sender, EventArgs e)
        {
            LoadGraphData();
        }

        private void LoadGraphData()
        {
            SalesByChart2.Series["Series1"].Points.Clear();
            SalesByChart2.DataSource = GetData();
            SalesByChart2.Series["Series1"].XValueMember = "Year";
            SalesByChart2.Series["Series1"].YValueMembers = "Total";
        }
    }
}
