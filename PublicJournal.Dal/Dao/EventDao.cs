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
    public class EventDao : AbstractDao<Event>, IEventDao
    {
        public EventDao(IObjectContext objectContext)
            : base(objectContext)
        {
        }

        public Event GetEvent(int id)
        {
            var query = from obj in _objectSet 
                        where obj.Id == id                        
                        select obj;           
            return query.SingleOrDefault();
        }

        public List<Event> GetListEventsByCategoryId(int categoryId)
        {
            var query = from obj in _objectSet
                        where obj.GenericEvent.EventCategories.Where(x=>x.CategoryId == categoryId).ToList().Count > 0
                        select obj;
            return query.ToList();
        }

        public List<Event> GetListEventsByCategoryIdAndByCountry(int categoryId, int countryId)
        {
            var query = from obj in _objectSet
                        where obj.GenericEvent.EventCategories.Where(x => x.CategoryId == categoryId).ToList().Count > 0
                        && obj.CountryId == countryId
                        select obj;
            return query.ToList();
        }       
      
    }
}
