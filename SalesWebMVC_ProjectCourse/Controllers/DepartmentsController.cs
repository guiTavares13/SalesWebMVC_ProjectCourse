using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC_ProjectCourse.Models;

namespace SalesWebMVC_ProjectCourse.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> List = new List<Department>();
            List.Add(new Department { Id = 1, Name = "Eletronics" });
            List.Add(new Department { Id = 2, Name = "Fachion" });

            //enviar para view os dados inseridos na lista
            return View(List);
        }
    }
}
