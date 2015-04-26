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
    public class UserEventHistoryDao : AbstractDao<UserEventHistory>, IUserEventHistoryDao
    {
        public UserEventHistoryDao(IObjectContext objectContext)
            : base(objectContext)
        {
        }
        
        public List<UserEventHistory> GetAllRevenues()
        {
            var query = from obj in _objectSet                                               
                        select obj;           
            return query.ToList();
        }        
      
    }
}

