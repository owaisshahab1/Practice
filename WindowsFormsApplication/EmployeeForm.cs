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
            try
            {
            string connString = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;

            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand("AddNewEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@EmployeeId", SqlDbType.NVarChar, 8).Value = EmployeeIdTextBox.Text;
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Value = FirstNameTextBox.Text;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Value = LastNameTextBox.Text;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = EmailTextBox.Text;
            cmd.Parameters.Add("@Telephone", SqlDbType.NVarChar, 50).Value = TelephoneTextBox.Text;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
                MessageBox.Show("New Employee Added succussfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :", ex.Message);
            }
        }
    }
}
