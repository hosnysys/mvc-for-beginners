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
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            foreach (string key in formCollection.Keys)
            {
                Response.Write("<b>Key:</b> " + key + " <b>Value:</b> " + formCollection[key]);
                Response.Write("<br>");
            }

            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();

            Employee employee = new Employee();
            employee.Name = formCollection["Name"];
            employee.Gender = formCollection["Gender"];
            employee.City = formCollection["City"];
            employee.DateOfBirth = Convert.ToDateTime(formCollection["DateOfBirth"]);

            employeeBusinessLayer.AddEmployee(employee);

            return RedirectToAction("Index");
        }
    }
}