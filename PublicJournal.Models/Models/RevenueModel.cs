using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PublicJournal.Models.Models
{
    public class RevenueModel
    {        
        public int EventId {get; set;}

        public string EventName { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public int NoOfParticipants { get; set; }

        public decimal Revenues { get; set; }

        public string Category { get; set; }
    }
}