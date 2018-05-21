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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataSet dsOffice = new DataSet("Office");
            DataTable dtEmployee = new DataTable("Employees");
            dtEmployee.Columns.Add("Id",typeof(int));
            dtEmployee.Columns.Add("Name");

            dtEmployee.Rows.Add(1, "Javed Iqbal");
            dtEmployee.Rows.Add(2, "Tony Marks");

            dsOffice.Tables.Add(dtEmployee);

            //EmployeeDataGridView.DataSource = dsOffice.Tables["Employees"];

            EmployeeDataGridView.DataSource = dtEmployee;

        }
    }
}
