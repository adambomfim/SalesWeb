using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvcTwo.Models;

namespace SalesWebMvcTwo.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> department = new List<Department>();
            department.Add(new Department { Nome = "Compras", Id = 1 });


            return View(department);
        }
    }
}
