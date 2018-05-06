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
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
                string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using(SqlCommand cmd = new SqlCommand("usp_StudentInsertDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = NameTextBox.Text;
                    cmd.Parameters.AddWithValue("Email", emailTextBox.Text);
                    cmd.Parameters.AddWithValue("IsInterestedInCSharp", IsCSharpCheckBox.Checked);
                    cmd.Parameters.AddWithValue("IsInterestedInVb", IsVbCheckBox.Checked);
                    cmd.Parameters.AddWithValue("IsInterestedInSql", IsSqlCheckBox.Checked);
                    cmd.Parameters.AddWithValue("GenderId", GetGender());
                    cmd.Parameters.AddWithValue("DateOfBirth", DobDateTimePicker.Value.Date);
                    conn.Open();
                    // execute reader for select
                    // executescalar for select
                    // executeNoQuery for insert,update,delete
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("your information is save successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }

        }

        public enum gender
        {
            NoSelection = 0,
            Male = 1,
            Female = 2,
            
        }

        private int GetGender()
        {
            if (MaleRadioButton.Checked)
            {
                return (int)gender.Male;
            }
            else if (FemaleRadioButton.Checked)
            {
                return (int)gender.Female;
            }
            return (int)gender.NoSelection;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DobDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void DobDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) 
            {
                DobDateTimePicker.CustomFormat = " ";
            }
        }
    }
}
