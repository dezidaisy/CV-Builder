using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CVApp1.Controllers
{
    public class Cert: Controller
    {
        public static Models.Cert model = new Models.Cert();
        public static List <Models.Cert> model1 = new List<Models.Cert>();

        public IActionResult Index()
        {
            return this.View(model);
        }
        public IActionResult Certification()
        {
            // model.Add(Edu1);

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Certification(Models.Cert Cert1)
        {
            //model[0].Institute = "abc";
            model1.Add(Cert1);
            HomeController.model.Certifications = model1;
            //model.RemoveAt(model.IndexOf(Edu1));
            //model.Institute = "ddd";
            return this.View();
        }
    }
}