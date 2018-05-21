using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            dtEmployee.Columns.Add("Id", typeof(System.Int32));
            dtEmployee.Columns.Add("Name", typeof(string));
            dtEmployee.Columns.Add("City", typeof(string));
            dtEmployee.Columns.Add("Age", typeof(System.Int32));

            dtEmployee.Rows.Add(1, "owais shahab", "Karachi", 27);
            dtEmployee.Rows.Add(2, "Waqas shahab", "Karachi", 27);
            dtEmployee.Rows.Add(3, "faisal shahab", "Lahore", 27);
            dtEmployee.Rows.Add(4, "fahad shahab", "Lahore", 27);
            dtEmployee.Rows.Add(5, "Jibran Qureshi", "Peshawar", 27);
            dtEmployee.Rows.Add(6, "Ahad Siddique", "Peshawar", 27);

            return dtEmployee;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            dvEmployeeView.RowFilter = "Name Like '%" + SearchTextBox.Text + "%'"; 
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (SortByNameRadioButton.Checked)
            {
                dvEmployeeView.Sort = "Name Asc";
            }
            else
            {
                dvEmployeeView.Sort = "City Asc";
            }
        }
    }
}
