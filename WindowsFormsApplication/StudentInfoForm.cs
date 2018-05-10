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
                    cmd.Parameters.AddWithValue("DateOfBirth", (DobDateTimePicker.Text.Trim() == string.Empty) ? (DateTime?)null : DobDateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("StartTime", StartTimeDateTimePicker.Text.Trim() == string.Empty ? null as TimeSpan? : StartTimeDateTimePicker.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("EndTime", EndTimeDateTimePicker.Text.Trim() == string.Empty ? null as TimeSpan? : EndTimeDateTimePicker.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@FundTypeId", (FundTypeComboBox.SelectedIndex == -1) ? 0 : FundTypeComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@FeePaymentTypeId", FundTypeComboBox.SelectedIndex == -1 ? 0 : FeePaymentComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@Comments", commentsTextBox.Text);
                    cmd.Parameters.AddWithValue("@Address", addressTextBox.Text);
                    cmd.Parameters.AddWithValue("@LocalityId", localityComboBox.SelectedIndex == -1 ? 0 : localityComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@CityId", cityComboBox.SelectedIndex == -1 ? 0 : cityComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@PostalCode", postalCodeTextBox.Text);
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

        private void CourseDuration_ValueChange(object sender, EventArgs e)
        {
            GetCustomTimeFormat(sender, "HH:mm");
        }

        private static void GetCustomTimeFormat(object sender,string format)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            dtp.CustomFormat = format;
        }

        private void StartTimeDateTimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            GetCustomTimeFormat(sender, "HH:mm");
        }

        private void StartTimeDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                GetCustomTimeFormat(sender, " ");
            }
        }

        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            FundTypeComboBox.DataSource = GetListData((int)ListDataTypes.FundType);
            FundTypeComboBox.DisplayMember = "Description";
            FundTypeComboBox.ValueMember = "ListDataId";
            FundTypeComboBox.SelectedIndex = -1;

            FeePaymentComboBox.DataSource = GetListData((int)ListDataTypes.FeePaymemnt);
            FeePaymentComboBox.DisplayMember = "Description";
            FeePaymentComboBox.ValueMember = "ListDataId";
            FeePaymentComboBox.SelectedIndex = -1;

            cityComboBox.SelectedValueChanged -= new EventHandler(cityComboBox_SelectedValueChanged);

            cityComboBox.DataSource = GetAllCitiesData();
            cityComboBox.DisplayMember = "Description";
            cityComboBox.ValueMember = "CityId";
            cityComboBox.SelectedIndex = -1;

            cityComboBox.SelectedValueChanged += new EventHandler(cityComboBox_SelectedValueChanged);
        }

        private DataTable GetAllCitiesData()
        {
            DataTable dtCitiestData = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllCitiesData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtCitiestData.Load(reader);
                }
            }
            return dtCitiestData;
        }

        private DataTable GetListData(int listDataTypeId)
        {
            DataTable dtListData = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllListData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ListDataTypeId", listDataTypeId);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtListData.Load(reader);
                }
            }
            return dtListData;
        }

        private void cityComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            localityComboBox.DataSource = GetAllLocalitiesByCityId((int)cityComboBox.SelectedValue);
            localityComboBox.DisplayMember = "Description";
            localityComboBox.ValueMember = "LocalityId";
        }

        private object GetAllLocalitiesByCityId(int cityId)
        {
            DataTable dtLocalitiesData = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllLocalityData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CityId", cityId);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtLocalitiesData.Load(reader);
                }
            }
            return dtLocalitiesData;
        }
    }
}
