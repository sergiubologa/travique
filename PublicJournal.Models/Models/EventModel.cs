using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PublicJournal.Models.Models
{
    public class EventModel
    {        
        public int EventId {get; set;}

        public string EventName { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public CategoryModel Category { get; set; }
    }
}