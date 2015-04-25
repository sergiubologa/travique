using PublicJournal.Bll.Contracts;
using PublicJournal.Dal.Dao;
using PublicJournal.Models.Models;
using PublicJournal.Dal.Contracts;
using PublicJournal.Models.Converter;
using PublicJournal.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PublicJournal.Bll.Bus
{
    public class EventBus : IEventBus
    {
        private IEventDao _iEventDao;
       // private UserModel userModel;

        public EventBus(IEventDao iEventDao)
        {
            _iEventDao = iEventDao;
        }

        //public UserModel GetOne(LoginModel login)
        //{
        //    User user = _iUserDao.GetOne(login.Username);

        //    if (user != null)
        //    {
        //        if (user.Password == login.Password)
        //        {
        //            UserModel result = new UserModel();
        //            UserConverter.ConvertToModel(user, result);
        //            return result;
        //        }
        //        else
        //        {
        //            login.WrongPassword = "Password is incorrect!";
        //            login.WrongPasswordCounter++;
        //        }
        //    }
        //    else
        //    {
        //        login.WrongUsername = "Username is incorrect";
        //    }
        //    return null;
        //}
    }
}
