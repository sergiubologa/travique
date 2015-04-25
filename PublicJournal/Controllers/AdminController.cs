using PublicJournal.Bll.Contracts;
using PublicJournal.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PublicJournal.Controllers
{
    //[Authorize(Roles = "2")]
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
            List<RevenueModel> model = new List<RevenueModel>();
            model.Add(new RevenueModel()
            {
                EventId = 1,
                EventName = "EventTest",
                Revenues=10,
                StartDate = DateTime.Now.ToString("dd/MM/yyyy"),
                EndDate = DateTime.Now.ToString("dd/MM/yyyy")
            });

            List<CategoryModel> listCategories = _iCategoryBus.GetListCategories();

            
            return View("Index",model);
        }
    }
}