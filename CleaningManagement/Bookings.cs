using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningManagement
{
    public class Bookings
    {
        public string Details { get; set; }
        public DateTime TimeOfBooking { get; set; }

        public Bookings(string details, DateTime timeOfBooking)
        {
            Details = details;
            TimeOfBooking = timeOfBooking;
        }
    }
}
