using PublicJournal.Bll.Contracts;
using PublicJournal.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PublicJournal.Controllers
{   
    public class AdminController : Controller
    {
        private IUserBus _iuserBus;
        private IEventBus _iEventBus;
        private ICategoryBus _iCategoryBus;

        public AdminController(IUserBus iUserBus, IEventBus iEventBus, ICategoryBus iCategoryBus)
        {
            _iuserBus = iUserBus;
            _iEventBus = iEventBus;
            _iCategoryBus = iCategoryBus;
        }
        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                return null;
            }

            UserModel user = (UserModel) Session["user"];

            if (user.Role.IdUserRole == 1)
            {
                return null;
            }

            List<RevenueModel> listEventRevenues = new List<RevenueModel>();
            List<RevenueModel> listRevenues = new List<RevenueModel>(_iEventBus.GetAllRevenues());

            List<EventModel> listEvents = _iEventBus.GetAllEvents();
            foreach (EventModel item in listEvents)
            {
                RevenueModel itemRevenu = new RevenueModel()
                {
                    EventId = item.EventId,
                    Revenues = listRevenues.Where(x => x.EventId == item.EventId).Sum(y => y.Revenues),
                    StartDate = item.StartDate,
                    EndDate = item.EndDate,
                    NoOfParticipants = listRevenues.Where(x => x.EventId == item.EventId).Sum(y => y.NoOfParticipants),
                    EventName = item.EventName,
                    Category = item.Category.Name
                };
                listEventRevenues.Add(itemRevenu);
            }

            return View("Index", listEventRevenues);
        }
    }
}