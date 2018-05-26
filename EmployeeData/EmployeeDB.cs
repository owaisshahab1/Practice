
using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    public class EmployeeDB
    {
        public static void AddEmployee(Employee employee)
        {
            string connString = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;

            SqlConnection conn = new SqlConnection(connString);

            using (conn)
            {
                SqlCommand cmd = new SqlCommand("AddNewEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@EmployeeId", SqlDbType.NVarChar, 8).Value = employee.EmployeeId;
                cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Value = employee.FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Value = employee.LastName;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = employee.Email;
                cmd.Parameters.Add("@Telephone", SqlDbType.NVarChar, 50).Value = employee.Telephone;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
