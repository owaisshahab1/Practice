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

        public void AddNewEmployee(Employee employee)
        {
            NewMvcPracticeDBContext db = new NewMvcPracticeDBContext();
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public Employee GetEmployeeDetailsById(int id)
        {
            NewMvcPracticeDBContext db = new NewMvcPracticeDBContext();
            return db.Employees.Find(id);
        }

        public void UpdateEmployeeDetails(Employee employee)
        {
            NewMvcPracticeDBContext db = new NewMvcPracticeDBContext();
            db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            NewMvcPracticeDBContext db = new NewMvcPracticeDBContext();
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();

        }
    }
}