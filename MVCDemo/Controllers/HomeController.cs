using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Courses = new List<string>
            {
                "Java",
                "JavaScript",
                "Python"
            };

            return View();
        }
    }
}