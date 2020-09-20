using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Notification.Controllers
{
    public class ModulesController : Controller
    {
        public IActionResult Module1()
        {
            return View();
        }
        public IActionResult Modules2()
        {
            return View();
        }
        public IActionResult Modules3()
        {
            return View();
        }
    }
}
