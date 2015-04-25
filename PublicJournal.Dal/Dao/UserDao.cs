using PublicJournal.Dal.Contracts;
using PublicJournal.Dal.Dao;
using PublicJournal.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace PublicJournal.Dal.Dao
{
    public class UserDao : AbstractDao<User>, IUserDao
    {
        public UserDao(IObjectContext objectContext)
            : base(objectContext)
        {
        }

        public User GetOne(string username)
        {
            var query = from obj in _objectSet 
                        where obj.Username == username                        
                        select obj;           
            return query.SingleOrDefault();
        }
        //CITESTE CODING STANDARDS!!!!!!
    }
}
