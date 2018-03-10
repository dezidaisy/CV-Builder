using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CVApp1
{
    public class WordDocumentAttribute : ActionFilterAttribute
    {
        public string DefaultFilename { get; set; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            ViewResult result = new ViewResult();
            result=(ViewResult) filterContext.Result;

            if (result != null)
                result.ViewName = "~/Views/Home/CVDocument.cshtml";

            ((Controller)(filterContext.Controller)).ViewBag.WordDocumentMode = true;

            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            var filename = ((Controller)(filterContext.Controller)).ViewBag.WordDocumentFilename;
            filename = filename ?? DefaultFilename ?? "Document";

            filterContext.HttpContext.Response.Headers["Content-Disposition "]= "filename="+ filename +".doc" ;
            filterContext.HttpContext.Response.ContentType = "application/msword";
            
            base.OnResultExecuted(filterContext);
        }
    }
}
