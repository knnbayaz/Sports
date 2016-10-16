using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sports.Models;

namespace Sports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }


        [Produces("application/json")]
        public IActionResult BaseApi()
        {
            TodoItem todo = new TodoItem();

            todo.TaskName = "Sample";
            todo.TaskDefiniton = "Sample Definiton";
            todo.DueDate = new DateTime(2016, 10, 17);

            return Json(todo);
        }
    }
}
