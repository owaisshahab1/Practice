using NewMvcPractice.Models;
using NewMvcPractice.ViewModel.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewMvcPractice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            List<Employee> employees = employeeVM.GetAllEmployee();
            return View(employees);
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                EmployeeViewModel employeeVm = new EmployeeViewModel();
                employeeVm.AddNewEmployee(employee);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }


        public ActionResult Details(int id)
        {
            EmployeeViewModel employeeVm = new EmployeeViewModel();
            Employee employee = employeeVm.GetEmployeeDetailsById(id);
            return View(employee);
        }


        public ActionResult Edit(int id)
        {
            EmployeeViewModel employeeVm = new EmployeeViewModel();
            Employee employee = employeeVm.GetEmployeeDetailsById(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                EmployeeViewModel employeeVm = new EmployeeViewModel();
                employeeVm.UpdateEmployeeDetails(employee);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            EmployeeViewModel employeeVm = new EmployeeViewModel();
            employeeVm.DeleteEmployee(id);
            return RedirectToAction("Index");

        }
    }
}