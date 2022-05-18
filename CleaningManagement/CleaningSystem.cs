using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningManagement
{
    public class CleaningSystem
    {
        public string Name { get; set; }
        public List<IProperties> Properties { get; set; }
        public List<IPeople> People { get; set; }
        public List<Bookings> SavedBookings { get; set; }
        public List<Customer> SavedCustomers { get; set; }

    public CleaningSystem(string name)
        {
            Name = name;
            Properties = new List<IProperties>();
            People = new List<IPeople>();
            SavedBookings = new List<Bookings>();
            SavedCustomers = new List<Customer>();
        }
    }
}
