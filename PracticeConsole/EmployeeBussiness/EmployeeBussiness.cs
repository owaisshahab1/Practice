using EmployeeData;
using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBussiness
{
    public class EmployeeService
    {
        public static void AddEmployee(Employee employee)
        {
            EmployeeDB.AddEmployee(employee);
        }

        public static Employee GetEmployeeByEmployeeId(string employeeId)
        {
            Employee emp = EmployeeDB.GetEmployeeByEmployeeId(employeeId);
            return emp;
        }
    }
}
