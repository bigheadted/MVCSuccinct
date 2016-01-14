using MVCSuccinctly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSuccinctly.Controllers
{
    public class ItineraryController : Controller
    {
        //
        // GET: /Itinerary/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(ItineraryItem data) 
        {
            if (ModelState.IsValid)
            {
                // Handle saving the data only if 
                // the model state is valid 
            }
            else 
            { 
                ModelState.AddModelError("", "The data you entered was not valid"); 
            }



            return View(); 
        }

 

    }
}
