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
        private SqlCommandBuilder cmdBuilder;
        private DataTable dtEmployee;
        private DataView dvEmployeeView;
        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbtest"].ConnectionString);

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

            using (cmd = new SqlCommand("usp_GetAllEmployees", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);

                dtEmployee.Columns.Add("Id", typeof(int));
                dtEmployee.Columns[0].AutoIncrement = true;
                dtEmployee.Columns[0].AutoIncrementSeed = 1;
                dtEmployee.Columns[0].AutoIncrementStep = 1;

                adapter.Fill(dtEmployee);
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

        private void EmployeeDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var hti = EmployeeDataGridView.HitTest(e.X, e.Y);
                EmployeeDataGridView.ClearSelection();
                EmployeeDataGridView.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to delete this record ?", "Deleting Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                int rowToDeleteIndex = EmployeeDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                EmployeeDataGridView.Rows.RemoveAt(rowToDeleteIndex);
               cmdBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dtEmployee);
                MessageBox.Show("Data is deleted successfully");
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dtEmployee.Rows.Add(null, "khashif", "karachi", 14);

            EmployeeDetailsForm edf = new EmployeeDetailsForm();
            edf.ShowDialog();
            if (!edf.IsCanceled)
            {
                dtEmployee.Rows.Add(null, edf.EmployeeAge, edf.EmployeeCity, edf.EmployeeAge);

                cmdBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dtEmployee);

                MessageBox.Show("New Data is Added successfully");
            }
        }
    }
}
