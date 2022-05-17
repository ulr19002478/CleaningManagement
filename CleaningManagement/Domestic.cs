using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CleaningManagement.Enums;

namespace CleaningManagement
{
    public class Domestic : IProperties
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public List<ICleaning> Issues { get; set; }
        public int NumberOfRooms { get; set; }
        public DomesticType Type { get; set; }
        public Customer Customer { get; set; }

        public Domestic(string address, int numberOfRooms, DomesticType type, Customer customer)
        {
            Id = Guid.NewGuid();
            Address = address;
            Issues = new List<ICleaning>();
            NumberOfRooms = numberOfRooms;
            Type = type;
            Customer = customer;
        }
        public override string ToString()
        {
            return $"Propety Id: {Id}  Address: {Address} Number of Rooms: {NumberOfRooms} Type: {Type}";
        }
    }
}
