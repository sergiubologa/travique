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
        private ICategoryBus _iCategoryBus;

        public EventsController(IEventBus iEventBus, ICategoryBus iCategoryBus)
        {
            _iEventBus = iEventBus;
            _iCategoryBus = iCategoryBus;
        }

        public ActionResult Index(int id)
        {
            // Get list off all events from this category
            
            // Create the EventsModel and return it to the view
            EventsModel model = new EventsModel();
            model.Category = _iCategoryBus.GetCategory(id);
            model.ListEvents = _iEventBus.GetListEventsByCategoryId(id);
            model.CategoryCssClass = model.Category.ImageName;

            return View(model);
        }

        public ActionResult Event(int id)
        {
            return View();
        }
	}
}