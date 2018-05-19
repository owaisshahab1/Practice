using NewMvcPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewMvcPractice.ViewModel.Home
{
    public class EmployeeViewModel
    {
        public List<Employee> GetAllEmployee()
        {
            NewMvcPracticeDBContext db = new NewMvcPracticeDBContext();
            return db.Employees.ToList();
        }
    }
}