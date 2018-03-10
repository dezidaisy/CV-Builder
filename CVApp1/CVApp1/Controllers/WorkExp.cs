using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CVApp1.Controllers
{
    public class WorkExp : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}