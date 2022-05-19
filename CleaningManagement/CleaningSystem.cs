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
        public List<Domestic> SavedDomestic { get; set; }
        public List<Commercial> SavedCommercial { get; set; }
        public List<Purchases> SavedPurchases { get; set; }
        public List<Major> SavedMIssues { get; set; }    
        public List<Cosmetic> SavedCIssues { get; set; }   
        public List<TeamMember> SavedStaff { get; set; }

    public CleaningSystem(string name)
        {
            Name = name;
            Properties = new List<IProperties>();
            People = new List<IPeople>();
            SavedBookings = new List<Bookings>();
            SavedCustomers = new List<Customer>();
            SavedDomestic = new List<Domestic>();
            SavedCommercial = new List<Commercial>();   
            SavedPurchases = new List<Purchases>();
            SavedMIssues = new List<Major>();
            SavedCIssues = new List<Cosmetic>();
            SavedStaff = new List<TeamMember>();    
        }
    }
}
