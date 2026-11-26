using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();

            List<Employee> employees = employeeBusinessLayer.Employee().ToList();


            return View(employees);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {

            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();

            if(ModelState.IsValid)
            {
                Employee employee = new Employee();
                UpdateModel(employee);

                employeeBusinessLayer.AddEmployee(employee);

                return RedirectToAction("Index");
            }

            return View();

        }
    }
}