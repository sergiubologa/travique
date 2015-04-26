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

        public HomeController(IUserBus iUserBus, ICategoryBus iCategoryBus)
        {
            _iUserBus = iUserBus;
            _iCategoryBus = iCategoryBus;
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
                ListCategories = new List<CategoryModel>(_iCategoryBus.GetListCategories())
            };            

            return View("Index", model);
        }
    }
}