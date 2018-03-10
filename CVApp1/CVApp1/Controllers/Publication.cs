using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CVApp1.Controllers
{
    public class Publication : Controller
    {
        public static Models.Publications model;
        public static List<Models.Publications> model1 = new List<Models.Publications>();

        public IActionResult Index()
        {
            return this.View(model);
        }
        public IActionResult Publications()
        {
            // model.Add(Edu1);

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Publications(Models.Publications Pubct1)
        {
            //model[0].Institute = "abc";
            model1.Add(Pubct1);
            HomeController.model.Publications= model1;
            //model.RemoveAt(model.IndexOf(Edu1));
            //model.Institute = "ddd";
            return this.View();
        }
    }
}