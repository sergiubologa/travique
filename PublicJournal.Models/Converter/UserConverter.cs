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
            userModel.IdUser = user.Id;
            userModel.Username = user.Username;
            userModel.FirstName = user.Firstname;
            userModel.LastName = user.Lastname;
            userModel.Password = user.Password;
            userModel.Address = String.Empty;
            userModel.CreatedDate = user.DateCreated;
            userModel.Role = new UserRoleModel()
                {
                    Description = user.Role.Description,
                    IdUserRole = user.Role.Id,
                    RoleName = user.Role.Name

                };
            //userModel.UpdatedByUser = user.UpdatedByUser;
            //userModel.UpdatedDate = user.UpdatedDate;
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
