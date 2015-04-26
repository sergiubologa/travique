using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicJournal.Models.Models;

namespace PublicJournal.Bll.Contracts
{
    public interface IEventBus
    {         
         EventModel GetEvent(int id);
         List<EventModel> GetAllEvents();
         List<EventModel> GetListEventsByCategoryId(int categoryId);
         List<EventModel> GetListEventsByCategoryIdAndByCountry(int categoryId, int countryId);
         List<RevenueModel> GetAllRevenues();
         bool SaveRevenue(int userId, int eventId);
    }
}


 