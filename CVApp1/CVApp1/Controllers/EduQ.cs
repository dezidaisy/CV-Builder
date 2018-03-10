using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CVApp1.Controllers
{
    public class EduQ : Controller
    {
        public static Models.EduQ model = new Models.EduQ();
        public static List<Models.EduQ> model1 = new List<Models.EduQ>();

        public IActionResult Index()
        {
            return this.View(model);
        }
        public IActionResult Education()
        {
            // model.Add(Edu1);

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Education(Models.EduQ Edu1)
        {
            //model[0].Institute = "abc";
            model1.Add(Edu1);
            HomeController.model.Education = model1;
            //model.RemoveAt(model.IndexOf(Edu1));
            //model.Institute = "ddd";
            return this.View();
        }
    }
}