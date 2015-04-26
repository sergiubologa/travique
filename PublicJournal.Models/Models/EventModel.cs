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

        public string Description { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string ImageName { get; set; }

        public CategoryModel Category { get; set; }

        public decimal PackagePrice { get; set; }

        public FlightModel Flight { get; set; }

        public HotelModel Hotel { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public decimal EventPrice { get; set; }

    }
}