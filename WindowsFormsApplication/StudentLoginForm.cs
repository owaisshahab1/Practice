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
    public partial class StudentLoginForm : Form
    {
        public StudentLoginForm()
        {
            InitializeComponent();
        }

        private void LogInbutton_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                try
                {
                    bool isUserNameCorrect, isPasswordCorrect;
                    GetUserLoginCorrect(out isUserNameCorrect, out isPasswordCorrect);
                    if (isUserNameCorrect && isPasswordCorrect)
                    {
                        this.Hide();
                        if (RememberMeCheckBox.Checked)
                        {
                            Properties.Settings.Default.UserName = userNameTextBox.Text;
                            Properties.Settings.Default.Save();
                        }
                        ManageStudentForm msf = new ManageStudentForm();
                        msf.ShowDialog();

                    }
                    else
                    {
                        if (!isUserNameCorrect)
                        {
                            MessageBox.Show("UserName is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            userNameTextBox.Clear();
                            PasswordtextBox.Clear();
                            userNameTextBox.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            PasswordtextBox.Clear();
                            PasswordtextBox.Focus();
                        }

                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetUserLoginCorrect(out bool isUserNameCorrect, out bool isPasswordCorrect)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_UserCheckLogInDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    cmd.Parameters.Add("@IsUserNameCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@IsPasswordCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@UserName", userNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordtextBox.Text);
                    cmd.ExecuteNonQuery();

                    isUserNameCorrect = (bool)cmd.Parameters["@IsUserNameCorrect"].Value;
                    isPasswordCorrect = (bool)cmd.Parameters["@IsPasswordCorrect"].Value;
                }
            }
        }

        private bool IsValidated()
        {

            if (userNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("UserName is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userNameTextBox.Clear();
                PasswordtextBox.Clear();
                userNameTextBox.Focus();
                return false;
            }

            else if (PasswordtextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordtextBox.Clear();
                PasswordtextBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void StudentLoginForm_Load(object sender, EventArgs e)
        {
            userNameTextBox.Text = Properties.Settings.Default.UserName;
        }
    }
}
