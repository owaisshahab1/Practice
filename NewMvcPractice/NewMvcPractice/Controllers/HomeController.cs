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
            List<Employees> employees = employeeVM.GetAllEmployee();
            return View(employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employees employee)
        {
            if (ModelState.IsValid)
            {
                EmployeeViewModel employeeVM = new EmployeeViewModel();
                employeeVM.AddNewEmployee(employee);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            Employees employee = employeeVM.GetEmployeeDetailById(id);
            return View(employee);
        }
    }
}