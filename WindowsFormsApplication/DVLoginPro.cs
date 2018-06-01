using DbDemo.Model;
using DbDemo.Service;
using DbDemo.Utilities;
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
            List<UserRole> userRoles = new List<UserRole>();
            LoginService.GetAllRoles(userRoles);
            foreach (var eachRole in userRoles)
            {
                RoleComboBox.Items.Add(eachRole.RoleDescription);
            }
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            LoginUser loginUser = new LoginUser()
            {
                UserName = UserNameTextBox.Text,
                Password = PasswordTextBox.Text,
                Role = RoleComboBox.Text,
                AreCredentialsCorrect = false,
                IsUserNameCorrect = false,
                IsPasswordCorrect = false,
                IsRoleCorrect = false
            };

            LoginService.Authenticated(loginUser);

            if(loginUser.AreCredentialsCorrect)
            {
                this.Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
            else
            {
                if (!loginUser.IsUserNameCorrect)
                {
                    MessageBox.Show("No Such User Exists", "No User Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!loginUser.IsPasswordCorrect && loginUser.IsRoleCorrect)
                    {
                        MessageBox.Show("Password is wrong", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!loginUser.IsPasswordCorrect && !loginUser.IsRoleCorrect)
                    {
                        MessageBox.Show("Both Password and Role are wrong", "Wrong Password and Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!loginUser.IsRoleCorrect && loginUser.IsPasswordCorrect)
                    {
                        MessageBox.Show("Role is not associated with this user", "Wrong Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
