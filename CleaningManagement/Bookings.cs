using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningManagement
{
    public class Bookings
    {
        public Guid Id { get; set; }
        public string Details { get; set; }
        public DateTime TimeOfBooking { get; set; }
        public Customer Customer { get; set; }

        public Bookings(string details, Customer customer)
        {
            Id = Guid.NewGuid();
            Details = details;
            TimeOfBooking = DateTime.Now;
            Customer = customer;
        }
        public override string ToString()
        {
            return $"Issue Id: {Id} Details: {Details} Time of booking: {TimeOfBooking}";
        }
    }
}
