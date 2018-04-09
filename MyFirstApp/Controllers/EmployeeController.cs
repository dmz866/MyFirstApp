using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApp.Controllers
{
    public class EmployeeController : Controller
    {
        //public IActionResult Index()
        public string Index()
        {
            //return View();
            return "String is from MVC Controller";
        }
    }
}