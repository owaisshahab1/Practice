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
    }
}