using PublicJournal.Bll.Contracts;
using PublicJournal.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PublicJournal.Controllers
{
    //[Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private IUserBus _iuserBus;

        public AdminController(IUserBus _iuser)
        {
            _iuserBus = _iuser;
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
            
            return View("Index",model);
        }
    }
}