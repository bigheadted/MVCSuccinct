using MVCSuccinctly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSuccinctly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new GreetingModel
            {
                Greeting = "Welcome to the World of MVC",
                Name = "Your friendly neighborhood MVC App"
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
