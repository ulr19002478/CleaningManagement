using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningManagement
{
    public class Services
    {
        public Guid Id { get; set; }
        public string Information { get; set; }
        public bool Open { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }

        public Services(string information, bool open)
        {
            Id = Guid.NewGuid();
            Information = information;
            Open = open;
            DateStarted = DateTime.Now;
            DateEnded = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Service Id: {Id} Details: {Information} Date Started: {DateStarted} Date Ended: {DateEnded}";
        }

    }
}
