using NewMvcPractice.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NewMvcPractice.ViewModel.Home
{
    public class EmployeeViewModel
    {
        public List<Employees> GetAllEmployee()
        {
            List<Employees> employeesList = new List<Employees>();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_EmployeesGetAllEmployees", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employees employee = new Employees();
                        employee.EmployeeId = (int)reader["EmployeeId"];
                        employee.Name = (string)reader["Name"];
                        employee.Email = (string)reader["Email"];
                        employee.Mobile = (string)reader["Mobile"];

                        employeesList.Add(employee);
                    }
                }
            }

            return employeesList;
        }

        public Employees GetEmployeeDetailById(int id)
        {
            Employees employee = new Employees();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd  = new SqlCommand ("usp_EmployeesGetAllEmployeeById",conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    employee.EmployeeId = Convert.ToInt16(reader["EmployeeId"]);
                    employee.Name = Convert.ToString(reader["Name"]);
                    employee.Email = Convert.ToString(reader["Email"]);
                    employee.Mobile = (reader["Mobile"]).ToString();
                }

            }
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_EmployeesDeleteEmployeeRecord", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEmployeeDetails(Employees employee)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_EmployeesUpdateRecord", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                    cmd.Parameters.AddWithValue("@Name", employee.Name);
                    cmd.Parameters.AddWithValue("@Email", employee.Email);
                    cmd.Parameters.AddWithValue("@Mobile", employee.Mobile);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddNewEmployee(Employees employee)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_EmployeesAddNewEmployee", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Name", employee.Name);
                    cmd.Parameters.AddWithValue("@Email", employee.Email);
                    cmd.Parameters.AddWithValue("@Mobile", employee.Mobile);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}