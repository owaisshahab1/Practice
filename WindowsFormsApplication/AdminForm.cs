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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void aboutDVLoginProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DV Login Pro v1.0.0", "About DV Login Pro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignOUt();
        }

        private void SignOUt()
        {
            this.Hide();
            DVLoginPro loginForm = new DVLoginPro();
            loginForm.Show();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            SignOUt();
        }
    }
}
