using PublicJournal.Bll.Contracts;
using PublicJournal.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PublicJournal.Controllers
{
    public class HomeController : Controller
    {
        private IUserBus _iUserBus;
        private ICategoryBus _iCategoryBus;
        private IEventBus _iEventBus;

        public HomeController(IUserBus iUserBus, ICategoryBus iCategoryBus, IEventBus iEventBus)
        {
            _iUserBus = iUserBus;
            _iCategoryBus = iCategoryBus;
            _iEventBus = iEventBus;
        }
        private LoginModel loginModel;

        public HomeController(LoginModel login) 
        {
            loginModel = login;
        }

        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel()
            {
                ListCategories = new List<CategoryModel>(_iCategoryBus.GetListCategories()),
                ListEvents = new List<EventModel>(_iEventBus.GetAllEvents())
            };            

            return View("Index", model);
        }
    }
}