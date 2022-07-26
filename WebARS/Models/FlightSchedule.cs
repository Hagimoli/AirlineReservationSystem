using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebARS.Models
{
    // LỊCH BAY
    public class FlightSchedule
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }

    }
}