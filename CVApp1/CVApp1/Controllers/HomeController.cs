using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CVApp1.Models;
using Microsoft.AspNetCore.Http;

namespace CVApp1.Controllers
{
    public class HomeController : Controller
    {
        public static CV model = new CV();
        public static Models.EduQ Edu = new Models.EduQ();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CV()
        {
            ViewData["Message"] ="Your application description page.";

            return this.View(model);
        }

        [WordDocument]
        public ActionResult CVDocument()
        {
            ViewBag.WordDocumentFilename = "CVDocument";
            return View("CV",model);
        }

        [HttpPost]
        public IActionResult CV(IFormCollection Form)
        {
            string x;
            for (int i = 0; i < model.Education.Count; i++)
            {
                x = Form["a-" + i.ToString()].ToString();
                if (x == "on")
                {
                    model.Education.RemoveAt(i);
                }
            }

            for (int i = 0; i < model.Publications.Count; i++)
            {
                x = Form["b-" + i.ToString()].ToString();
                if (x == "on")
                {
                    model.Publications.RemoveAt(i);
                }
            }

            for (int i = 0; i < model.Certifications.Count; i++)
            {
                x = Form["c-" + i.ToString()].ToString();
                if (x == "on")
                {
                    model.Certifications.RemoveAt(i);
                }
            }

            for (int i = 0; i < model.WorkExp.Count; i++)
            {
                x = Form["d-" + i.ToString()].ToString();
                if (x == "on")
                {
                    model.WorkExp.RemoveAt(i);
                }
            }

            return View(model);
        }
        public IActionResult Details()
        {
           // ViewData["Message"] = "Your contact page.";

            return View(model);
        }

        [HttpPost]
        public IActionResult Details(CV CV1)
        {
            //ViewData["Message"] = "Your contact page.";
            model = CV1;
            return View(model);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
