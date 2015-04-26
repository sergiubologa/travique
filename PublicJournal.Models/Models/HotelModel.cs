using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicJournal.Models.Models
{
    public class HotelModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Stars { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public decimal PricePerNight { get; set; }
    }
}
