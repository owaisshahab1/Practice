﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPractice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            return View();
        }

        public string WelcomeMessage()
        {
            return "Welcome to Asp.Net MVC";
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}