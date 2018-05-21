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
    public partial class EmployeeNavigationForm : Form
    {
        public EmployeeNavigationForm()
        {
            InitializeComponent();
        }

        private DataTable dtEmp;
        private int index;
        private DataRow row;

        private void EmployeeNavigationForm_Load(object sender, EventArgs e)
        {
            dtEmp = GetData();
            FirstNameTextBox.DataBindings.Add("Text", dtEmp, "FirstName");
            LastNameTextBox.DataBindings.Add("Text", dtEmp, "LastName");
        }

        private DataTable GetData()
        {
            DataTable dtEmployee = new DataTable();
            dtEmployee.Columns.Add("FirstName", typeof(string));
            dtEmployee.Columns.Add("LastName", typeof(string));
            dtEmployee.Rows.Add("James", "Smith");
            dtEmployee.Rows.Add("Mark", "Max");
            dtEmployee.Rows.Add("Julian ", "Sams");

            return dtEmployee;
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            row = dtEmp.Rows[0];
            FirstNameTextBox.Text = row["FirstName"].ToString();
            LastNameTextBox.Text = row["LastName"].ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (index < dtEmp.Rows.Count - 1)
            {
                index++;
                row = dtEmp.Rows[index];
            }
            else
            {
                row = dtEmp.Rows[0];
                index = 0;
            }
            FirstNameTextBox.Text = row["FirstName"].ToString();
            LastNameTextBox.Text = row["LastName"].ToString();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                row = dtEmp.Rows[index];
            }
            else
            {
                row = dtEmp.Rows[dtEmp.Rows.Count - 1];
                index = dtEmp.Rows.Count - 1;
            }

            FirstNameTextBox.Text = row["FirstName"].ToString();
            LastNameTextBox.Text = row["LastName"].ToString();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            row = dtEmp.Rows[dtEmp.Rows.Count - 1];
            FirstNameTextBox.Text = row["FirstName"].ToString();
            LastNameTextBox.Text = row["LastName"].ToString();
        }
    }
}
