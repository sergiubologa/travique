using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicJournal.Models.Models
{
    public class EventsModel
    {
        public List<EventModel> ListEvents { get; set; }
        public CategoryModel Category{ get; set; }

        public string CategoryCssClass { get; set; }
        //public string SelectedCategoryName { get; set; }
        //public string Description { get; set; }
    }
}
