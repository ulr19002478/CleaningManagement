using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningManagement
{
    public class Purchases
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public DateTime CreatedOn { get; set; }

        public Purchases(string description, double cost)
        {
            Id = Guid.NewGuid();
            Description = description;
            Cost = cost;
            CreatedOn = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Service Id: {Id} Details: {Description} Date Created: {CreatedOn}";
        }
    }
}
