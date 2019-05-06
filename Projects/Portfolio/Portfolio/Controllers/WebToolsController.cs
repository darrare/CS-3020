using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class WebToolsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult ReadFast()
        {
            return View();
        }

        public IActionResult RecursiveTree()
        {
            return View();
        }

        public IActionResult FlockingSimulation()
        {
            return View();
        }
    }
}