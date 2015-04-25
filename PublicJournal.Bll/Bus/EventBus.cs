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

        public EventBus(IEventDao iEventDao)
        {
            _iEventDao = iEventDao;
        }
                     

        public EventModel GetEvent(int id)
        {
            Event eventDB = _iEventDao.GetEvent(id);
            return EventConverter.ConvertToModel(eventDB);
        }

        public List<EventModel> GetListEventsByCategoryId(int categoryId)
        {
            List<Event> listEventDB = _iEventDao.GetListEventsByCategoryId(categoryId);
            return listEventDB.Select(x => EventConverter.ConvertToModel(x)).ToList();
        }

        public List<EventModel> GetListEventsByCategoryIdAndByCountry(int categoryId, int countryId)
        {
            List<Event> listEventDB = _iEventDao.GetListEventsByCategoryIdAndByCountry(categoryId, countryId);
            return listEventDB.Select(x => EventConverter.ConvertToModel(x)).ToList();
        }
    }
}
