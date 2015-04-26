using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicJournal.Models.Models
{
    public class FlightModel
    {
        public string AirportDeparture { get; set; }
        public string AirportLanding { get; set; }
        public string CityDeparture { get; set; }
        public string CityLanding { get; set; }
        public string DepartureTime { get; set; }
        public string LandingTime { get; set; }
        public decimal TicketPrice { get; set; }
    }
}
