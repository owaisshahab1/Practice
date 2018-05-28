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
    }
}
