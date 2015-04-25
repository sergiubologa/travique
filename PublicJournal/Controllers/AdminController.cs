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
        public ActionResult Index()
        {
            var user = LoggedUser();
            if (user == null || user.Role.RoleName != "Admin")
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        private UserModel LoggedUser()
        {
            return (UserModel)Session["user"];
        }
    }
}