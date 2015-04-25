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
    public static class UserConverter
    {
        public static UserModel ConvertToModel(User user, UserModel userModel)
        {
          //  userModel.IdUser = user.IdUser;
          //  userModel.Username = user.Username;
          //  userModel.FirstName = user.FirstName;
          //  userModel.LastName = user.LastName;
          //  userModel.Password = user.Password;
          //  userModel.Address = user.Address;
          //  userModel.CreatedDate = user.CreatedDate;
          // // userModel.Role.Description = user.UserRole.Description;
          ////  userModel.Role.IdUserRole = user.UserRole.IdUserRole;
          ////  userModel.Role.RoleName = user.UserRole.RoleName;
          //  userModel.UpdatedByUser = user.UpdatedByUser;
          //  userModel.UpdatedDate = user.UpdatedDate;
            return userModel;
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
