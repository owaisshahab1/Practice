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
    public partial class EmployeeDetailsForm : Form
    {
        public EmployeeDetailsForm()
        {
            InitializeComponent();
        }

        private string employeeName;
        private string employeeCity;
        private int employeeAge;
        private bool isCanceled;
        private bool isUpdate;

        public string EmployeeName
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }

        public string EmployeeCity
        {
            get
            {
                return employeeCity;
            }

            set
            {
                employeeCity = value;
            }
        }

        public int EmployeeAge
        {
            get
            {
                return employeeAge;
            }

            set
            {
                employeeAge = value;
            }
        }

        public bool IsCanceled
        {
            get
            {
                return isCanceled;
            }

            set
            {
                isCanceled = value;
            }
        }

        public bool IsUpdate
        {
            get
            {
                return isUpdate;
            }

            set
            {
                isUpdate = value;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                EmployeeName = this.NameTextBox.Text;
                EmployeeCity = this.CityTextBox.Text;
                EmployeeAge = int.Parse(this.AgeTextBox.Text);
                IsCanceled = false;
                this.Close();
            }
        }

        private bool IsValidated()
        {
            if (this.NameTextBox.Text == "")
            {
                ShowMessage("Name field should not be empty");
                this.NameTextBox.BackColor = Color.Yellow;
                this.NameTextBox.Focus();
                return false;
            }

            if (this.CityTextBox.Text == "")
            {
                ShowMessage("City field should not be empty");
                this.CityTextBox.BackColor = Color.Yellow;
                this.CityTextBox.Focus();
                return false;
            }

            if (this.AgeTextBox.Text == "")
            {
                ShowMessage("Age field should not be empty");
                this.AgeTextBox.BackColor = Color.Yellow;
                this.AgeTextBox.Focus();
                return false;
            }

            return true;
        }

        private void ShowMessage(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.NameTextBox.BackColor = Color.White;
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            this.CityTextBox.BackColor = Color.White;
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            this.AgeTextBox.BackColor = Color.White;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            IsCanceled = true;
            this.Close();
        }

        private void EmployeeDetailsForm_Load(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                this.NameTextBox.Text = EmployeeName;
                this.CityTextBox.Text = EmployeeCity;
                this.AgeTextBox.Text = EmployeeAge.ToString();
                SaveButton.Text = "Update";
            }
            else
            {
                SaveButton.Text = "Save";
            }
        }
    }
}
