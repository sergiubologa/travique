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
            EventModel eventModel = new EventModel();

            eventModel.EventId = eventDB.Id;
            eventModel.EndDate = eventDB.EndDate.ToString("dd-MM-yyyy");
            eventModel.StartDate = eventDB.StartDate.ToString("dd-MM-yyyy");
            eventModel.EventName = eventDB.Name;
            eventModel.ImageName = eventDB.ImageName;
            eventModel.Description = eventDB.Description;            

            eventModel.Category = new CategoryModel()
            {
                Id = int.Parse(eventDB.GenericEvent.EventCategories.ToList().Select(x => x.CategoryId).FirstOrDefault().ToString()),
                Name = eventDB.GenericEvent.EventCategories.ToList().Select(x => x.Category.Name).FirstOrDefault().ToString(),
                ImageName = eventDB.GenericEvent.EventCategories.ToList().Select(x => x.Category.ImageName).FirstOrDefault().ToString()
            };

            eventModel.Flight = new FlightModel()
            {
                //AirportDeparture = eventDB
            };
            return eventModel;
        }

        public static RevenueModel ConvertToRevenueModel(UserEventHistory revenue)
        {
            RevenueModel revenueModel = new RevenueModel();

            revenueModel.EventId = revenue.Event.Id;
            revenueModel.EndDate = revenue.Event.EndDate.ToString("dd-MM-yyyy");
            revenueModel.StartDate = revenue.Event.StartDate.ToString("dd-MM-yyyy");
            revenueModel.EventName = revenue.Event.Name;
            revenueModel.Revenues = revenue.Revenues;
            revenueModel.NoOfParticipants = revenue.NoOfPersons;
            
            return revenueModel;
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
