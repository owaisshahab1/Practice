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
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }

        private DataTable dtStudentData = new DataTable();


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentInfoForm(0, false);
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            dtStudentData = GetStudentList();
            studentListDataGridView.DataSource = dtStudentData;
        }

        private DataTable GetStudentList()
        {
            DataTable dtStudentData = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_StudentGetAllStudents", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtStudentData.Load(reader);
                }
            }
            return dtStudentData;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FilterStringByColumn("Name",nameTextBox);
        }

        private void FilterStringByColumn(string columnName, TextBox txt)
        {
            DataView dvStudents = dtStudentData.DefaultView;
            dvStudents.RowFilter = columnName + " LIKE  '%" + txt.Text + "%'";
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterStringByColumn("Address",addressTextBox);
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterStringByColumn("Email", emailTextBox);
        }

        private void resetFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emailTextBox.Clear();
            addressTextBox.Clear();
            nameTextBox.Clear();
        }

        private void studentListDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int rowToUpdate = studentListDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int studentId = Convert.ToInt32( studentListDataGridView.Rows[rowToUpdate].Cells["StudentId"].Value);
            ShowStudentInfoForm(studentId, true);

        }

        private void ShowStudentInfoForm(int studentId,bool isUpdate)
        {
            StudentInfoForm sif = new StudentInfoForm();
            sif.StudentId = studentId;
            sif.IsUpadte = isUpdate;
            sif.ShowDialog();
        }
    }
}
