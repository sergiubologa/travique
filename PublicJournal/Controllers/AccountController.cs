using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Mvc.Filters;
using System.Security.Principal;
using Microsoft.AspNet.Identity;
using PublicJournal.Models.Models;
using PublicJournal.Models.Converter;
using PublicJournal.Bll.Contracts;
using PublicJournal.Dal.Contracts;
using PublicJournal.Dal.Dao;
using PublicJournal.Bll.Bus;
using PublicJournal.Dal;


namespace PublicJournal.Controllers
{
    public class AccountController : Controller
    {
        private IUserBus _iuserBus;

        public AccountController(IUserBus _iuser)
        {
            _iuserBus = _iuser;
        }

        [HttpPost]
        public ActionResult LogIn(LoginModel login)
        {
            if (ModelState.IsValid)
            {
                var user = _iuserBus.GetOne(login);

                if (login.WrongPassword == null && login.WrongUsername == null)
                {
                    Session.Add("user", user);
                }
                else
                {
                    ModelState.AddModelError("Username", login.WrongUsername ?? " ");
                    ModelState.AddModelError("Password", login.WrongPassword ?? " ");
                }
            }
            return PartialView("_LoginPartial", login);
        }

        public ActionResult LogOff()
        {
            Session.Abandon();
            Session["user"] = null;
            return PartialView("_LoginPartial");
        }
    }
}