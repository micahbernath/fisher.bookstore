using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("about me");
        }

        public IActionResult Location()
        {
            return Content("the location page");
        }

        public IActionResult History()
        {
            return Content("history page");
        }
    }
}