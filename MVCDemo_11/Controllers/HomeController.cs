using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo_11.Models;

namespace MVCDemo_11.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //ViewData["Countries"] = new[] { "Canada", "Egypt", "France", "Japan", "Brazil" };

            Country country = new Country {

                Countries = new[] { "Canada", "Egypt", "France", "Japan", "Brazil" }
            };

            return View(country);
        }
    }
}