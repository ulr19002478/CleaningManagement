using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningManagement
{
    public class Cosmetic : ICleaning
    {
        public Guid Id { get; set; }
        public String CleaningType { get; set; }
        public DateTime Time { get; set; }
        public List<Purchases> Purchases { get; set; }
        public Customer Customer { get; set; }

        public Cosmetic(string cleaningType, Customer customer)
        {
            Id = Guid.NewGuid();
            CleaningType = cleaningType;
            Time = DateTime.Now;
            Purchases = new List<Purchases>();
            Customer = customer;
        }
        public override string ToString()
        {
            return $"Issue Id: {Id} Cleaning Type: {CleaningType} Time: {Time}";
        }

    }

}
