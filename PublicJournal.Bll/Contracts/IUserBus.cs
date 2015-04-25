using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicJournal.Models.Models;

namespace PublicJournal.Bll.Contracts
{
    public interface IUserBus
    {
         UserModel GetOne(LoginModel name);
    }
}
