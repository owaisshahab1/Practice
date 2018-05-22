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
    public partial class MainForm : Form
    {
        private DataTable dtEmployee;
        private DataView dvEmployeeView;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EmployeeDataGridView.DataSource = GetDataTable();
            dvEmployeeView = dtEmployee.DefaultView;
            SortByNameRadioButton.Checked = true;

        }

        private DataTable GetDataTable()
        {
            dtEmployee = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbtest"].ConnectionString))
            {
                using(SqlDataAdapter adapter = new SqlDataAdapter("usp_GetAllEmployees", conn))
                {
                    adapter.Fill(dtEmployee);
                }
            }

            return dtEmployee;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //dvEmployeeView.RowFilter = "Name Like '%" + SearchTextBox.Text + "%'"; 
            var retRows = from myRows in dtEmployee.AsEnumerable()
                          where myRows.Field<string>("Name").Contains(SearchTextBox.Text)
                          select myRows;
            if (retRows.Any())
                EmployeeDataGridView.DataSource = retRows.CopyToDataTable<DataRow>();
            else
                MessageBox.Show("No matching row found", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (SortByNameRadioButton.Checked)
            {
                var retRowName = from myRows in dtEmployee.AsEnumerable()
                                 orderby myRows["Name"] ascending
                                 select myRows; 
                EmployeeDataGridView.DataSource = retRowName.CopyToDataTable<DataRow>();
               // dvEmployeeView.Sort = "Name Asc";
            }
            else
            {
                // dvEmployeeView.Sort = "City Asc";
                var retRowCity = from myRows in dtEmployee.AsEnumerable()
                                 orderby myRows["City"] ascending
                                 select myRows;
                EmployeeDataGridView.DataSource = retRowCity.CopyToDataTable<DataRow>();
            }
        }
    }
}
