using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PublicJournal.Models.Models;
using PublicJournal.Dal;
using PublicJournal.Dal.Dao;


namespace PublicJournal.Models.Converter
{
    public static class EventConverter
    {
        public static EventModel ConvertToModel(Event eventDB)
        {
            EventModel eventModel = new EventModel()
            {
                EventId = eventDB.Id,
                EndDate = eventDB.EndDate.ToString("dd/MM/yyyy"),
                StartDate = eventDB.StartDate.ToString("dd/MM/yyyy"),
                EventName = eventDB.Name,
                ImageName = eventDB.ImageName,
                Category = new CategoryModel()
                {
                    Id = int.Parse(eventDB.GenericEvent.EventCategories.ToList().Select(x => new { x.CategoryId }).FirstOrDefault().ToString()),
                    Name = eventDB.GenericEvent.EventCategories.ToList().Select(x => new { x.CategoryId }).FirstOrDefault().ToString()
                }
            };
            return eventModel;
        }

        public static User ConvertToUser(User user, UserModel userModel)
        {
       //     user.IdUser = userModel.IdUser;
       //     user.Username = userModel.Username;
       //     user.FirstName = userModel.FirstName;
       //     user.LastName = userModel.LastName;
       //     user.Password = userModel.Password;
       //     user.Address = userModel.Address;
       //     user.CreatedDate = userModel.CreatedDate;
       ////     user.UserRole.Description = userModel.Role.Description;
       ////     user.UserRole.IdUserRole = userModel.Role.IdUserRole;
       ////     user.UserRole.RoleName = userModel.Role.RoleName;
       //     user.UpdatedByUser = userModel.UpdatedByUser;
       //     user.UpdatedDate = userModel.UpdatedDate;
            return user;
        }

        public static User ConvertToUserLogin(User user, LoginModel login)
        {
            //user.IdUser = login.IdUser;
            user.Username = login.Username;
            user.Password = login.Password;

            return user;
        }
    }
}
