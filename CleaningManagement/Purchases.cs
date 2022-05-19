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
        public string Name { get; set; }    
        public string Description { get; set; }
        public double Cost { get; set; }
        public DateTime CreatedOn { get; set; }
        public TeamMember CreatedBy { get; set; }

        public Purchases(string name, string description, double cost, TeamMember createdBy)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Cost = cost;
            CreatedOn = DateTime.Now;
            CreatedBy = createdBy;
        }
        public override string ToString()
        {
            return $"Item Id: {Id} Item Name: {Name} Item Description: {Description} Cost: £{Cost} Date Created: {CreatedOn}";
        }
    }
}
