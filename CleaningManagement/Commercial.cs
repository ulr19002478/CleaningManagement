using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CleaningManagement.Enums;

namespace CleaningManagement
{
    public class Commercial : IProperties
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public double Size { get; set; }
        public List<ICleaning> Issues { get; set; }
        public CommercialType Type { get; set; }
        public Customer Customer { get; set; }

        public Commercial(string address, double size, CommercialType type, Customer customer)
        {
            Id = Guid.NewGuid();
            Address = address;
            Size = size;
            Issues = new List<ICleaning>();
            Type = type;
            Customer = customer;
        }
        public override string ToString()
        {
            return $"Property Id: {Id}  Address: {Address} Size of Property: {Size} Type: {Type}";
        }
    }
}
