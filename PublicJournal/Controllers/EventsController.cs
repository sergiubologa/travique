using PublicJournal.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PublicJournal.Controllers
{
    public class EventsController : Controller
    {
        public ActionResult Index(int id)
        {
            // Get list off all events from this category

            // Create the EventsModel and return it to the view
            EventsModel model = new EventsModel();
            model.CategoryCssClass = "contemporary-music";

            return View(model);
        }
	}
}