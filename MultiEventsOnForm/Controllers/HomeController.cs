using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiEventsOnForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to kick-start your ASP.NET MVC application.";

            return View();
        }

        [HttpPost]
        [MultiButton(Name = "action", Argument = "Hello")]
        public ActionResult Hello(string name)
        {
            ViewBag.Message = "Hello " + name;

            return View("Index");
        }

        [HttpPost]
        [MultiButton(Name = "action", Argument = "Greeting")]
        public ActionResult Greeting(string name)
        {
            ViewBag.Message = "Greeting " + name;

            return View("Index");
        }
    }
}
