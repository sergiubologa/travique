using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicJournal.Models.Models
{
    public class HomeViewModel
    {
        public List<CategoryModel> ListCategories { get; set; }
        public List<EventModel> ListEvents { get; set; }

    }
}
