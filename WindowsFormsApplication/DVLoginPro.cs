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
    public partial class DVLoginPro : Form
    {
        public DVLoginPro()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DVLoginPro_Load(object sender, EventArgs e)
        {
            LoadAllRoles();
        }

        private void LoadAllRoles()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["loginprobdb"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("usp_GetAllRoles", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    RoleComboBox.Items.Add(reader[1]);
                }
                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            bool isCredentialsCorrect = false;
            bool isUserNameCorrect = false;
            bool isPasswordCorrect = false;
            bool isRoleCorrect = false;
            Authenticated(UserNameTextBox.Text,
                              PasswordTextBox.Text,
                              RoleComboBox.Text,
                              ref isCredentialsCorrect,
                              ref isUserNameCorrect,
                              ref isPasswordCorrect,
                              ref isRoleCorrect);
            if(isCredentialsCorrect)
            {
                MessageBox.Show("You are logged in successfully", "Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!isUserNameCorrect)
                {
                    MessageBox.Show("No Such User Exists", "No User Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!isPasswordCorrect && isRoleCorrect)
                    {
                        MessageBox.Show("Password is wrong", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!isPasswordCorrect && !isRoleCorrect)
                    {
                        MessageBox.Show("Both Password and Role are wrong", "Wrong Password and Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!isRoleCorrect && isPasswordCorrect)
                    {
                        MessageBox.Show("Role is not associated with this user", "Wrong Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Authenticated(string _userName,
                                    string _password,
                                    string _role,
                                    ref bool _IsCredentialsCorrect,
                                    ref bool _IsUserNameCorrect,
                                    ref bool _IsPasswordCorrect,
                                    ref bool _IsRoleCorrect)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["loginprobdb"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("usp_CheckIsUserCredentialsCorrect3", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = _userName;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = _password;
                cmd.Parameters.Add("@Role", SqlDbType.NVarChar, 50).Value = _role;

                cmd.Parameters.Add("@IsCredentialsCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@IsUserNameCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@IsPasswordCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@IsRoleCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;

                conn.Open();

                cmd.ExecuteNonQuery();

                _IsCredentialsCorrect = (bool)cmd.Parameters["@IsCredentialsCorrect"].Value;
                _IsUserNameCorrect = (bool)cmd.Parameters["@IsUserNameCorrect"].Value;
                _IsPasswordCorrect = (bool)cmd.Parameters["@IsPasswordCorrect"].Value;
                _IsRoleCorrect = (bool)cmd.Parameters["@IsRoleCorrect"].Value;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
