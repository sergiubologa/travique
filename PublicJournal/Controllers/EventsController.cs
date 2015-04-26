using PublicJournal.Bll.Contracts;
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
        private IEventBus _iEventBus;

        public EventsController(IEventBus iEventBus)
        {
            _iEventBus = iEventBus;            
        }

        public ActionResult Index(int id)
        {
            // Get list off all events from this category
            
            // Create the EventsModel and return it to the view
            EventsModel model = new EventsModel();
            model.ListEvents = _iEventBus.GetListEventsByCategoryId(id);
            model.CategoryCssClass = "electric-music";

            return View(model);
        }
	}
}