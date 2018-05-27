using EmployeeBussiness;
using EmployeeModel;
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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void AddNewEmployeeButton_Click(object sender, EventArgs e)
        {
            Employee emp = EmployeeDetails();
            EmployeeService.AddEmployee(emp);
            MessageBox.Show("New Employee Added succussfully");
        }

        private void FindEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
            string employeeId = EmployeeIdTextBox.Text;
            Employee emp = EmployeeService.GetEmployeeByEmployeeId(employeeId);
            FirstNameTextBox.Text = emp.FirstName.ToString();
            LastNameTextBox.Text = emp.LastName.ToString();
            EmailTextBox.Text = emp.Email.ToString();
            TelephoneTextBox.Text = emp.Telephone.ToString();
            UpdateRecordButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateRecordButton_Click(object sender, EventArgs e)
        {
            Employee emp = EmployeeDetails();
            EmployeeService.UpdateEmployee(emp);
            MessageBox.Show("Employee Update succussfully");
        }

        private Employee EmployeeDetails()
        {
            return new Employee()
            {
                EmployeeId = EmployeeIdTextBox.Text,
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Email = EmailTextBox.Text,
                Telephone = TelephoneTextBox.Text
            };
        }
    }
}
