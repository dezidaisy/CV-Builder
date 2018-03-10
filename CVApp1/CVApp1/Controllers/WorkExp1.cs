using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CVApp1.Controllers
{
    public class WorkExp1: Controller
    {
        public static Models.WorkExp model = new Models.WorkExp();
        public static List <Models.WorkExp> model1 = new List<Models.WorkExp>();

        public IActionResult Index()
        {
            return this.View(model);
        }
        public IActionResult WorkExp()
        {
            // model.Add(Edu1);

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult WorkExp(Models.WorkExp WExp1)
        {
            //model[0].Institute = "abc";
            model1.Add(WExp1);
            HomeController.model.WorkExp = model1;
            //model.RemoveAt(model.IndexOf(Edu1));
            //model.Institute = "ddd";
            return this.View();
        }
    }
}