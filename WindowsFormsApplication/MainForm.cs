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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EmployeeDataGridView.DataSource = GetDataTable();
            //EmployeeDataGridView.DataSource = dsOffice.Tables["Employees"];

            //EmployeeDataGridView.DataSource = dtEmployee;
        }

        private DataTable GetDataTable()
        {
            DataTable dtEmployee = new DataTable();
            //DataColumn dcEmployeeId = new DataColumn();
            //dcEmployeeId.ColumnName = "Id";
            //dcEmployeeId.DataType = typeof(System.Int32);
            //dcEmployeeId.AllowDBNull = false;
            //dcEmployeeId.AutoIncrement = true;
            //dcEmployeeId.AutoIncrementSeed = 1001;
            //dcEmployeeId.AutoIncrementStep = 1;
            //dcEmployeeId.Unique = true;
            //dtEmployee.Columns.Add(dcEmployeeId);

            //DataColumn dcEmployeeName = new DataColumn();
            //dcEmployeeName.ColumnName = "Name";
            //dcEmployeeName.DataType = typeof(System.String);
            //dcEmployeeName.AllowDBNull = false;
            //dcEmployeeName.AutoIncrement = false;
            //dtEmployee.Columns.Add(dcEmployeeName);

            DataColumn dcEmployeeId = DataColumnCreater("Id", typeof(System.Int32), false, true, true, 1001, 1);
            dtEmployee.Columns.Add(dcEmployeeId);

            DataColumn dcEmployeeName = DataColumnCreater("Name", typeof(System.String), false, false, false);
            dtEmployee.Columns.Add(dcEmployeeName);

            dtEmployee.Rows.Add(null, "James");
            dtEmployee.Rows.Add(null, "Kims");
            dtEmployee.Rows.Add(null, "Robert");

            return dtEmployee;
        }

        private DataColumn DataColumnCreater(string columnName,Type dataType,bool allowDbNull,bool unique,bool autoIncrement,int autoIncrementSeed = 0,int autoIncrementStep = 0)
        {
            DataColumn dtColumn = new DataColumn();

            dtColumn.ColumnName = columnName;
            dtColumn.DataType = dataType;
            dtColumn.AllowDBNull = allowDbNull;
            dtColumn.Unique = unique;
            dtColumn.AutoIncrement = autoIncrement;
            if (autoIncrement == true)
            {
                dtColumn.AutoIncrementSeed = autoIncrementSeed;
                dtColumn.AutoIncrementStep = autoIncrementStep;
            }
            return dtColumn;
        }

            //private DataTable GetDataTable()
            //{
            //    //DataSet dsOffice = new DataSet("Office");
            //    DataTable dtEmployee = new DataTable("Employees");
            //    dtEmployee.Columns.Add("Id", typeof(int));
            //    dtEmployee.Columns.Add("Name");

            //    dtEmployee.Rows.Add(1, "Javed Iqbal");
            //    dtEmployee.Rows.Add(2, "Tony Marks");

            //    return dtEmployee;
            //    //dsOffice.Tables.Add(dtEmployee);
            //}
        }
}
