using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPractice.Areas.Hr.Models
{
    public class DefaultController : Controller
    {
        // GET: Hr/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}