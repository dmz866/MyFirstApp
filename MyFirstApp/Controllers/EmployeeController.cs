using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Models;

namespace MyFirstApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var employee = new Employee() { EmployeeID = 1, EmployeeName = "David Murillo" };
            return View(employee);
        }

        /* 
        public string Index()
        {
            return "String is from MVC Controller";
        }
        */
    }
}