using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CleaningManagement.Enums;

namespace CleaningManagement
{
    public class Major : ICleaning
    {
        public Guid Id { get; set; }
        public String CleaningType { get; set; }
        public DateTime Time { get; set; }
        public Severity Severity { get; set; }
        public List<Purchases> Purchases { get; set; }

        public Major(string cleaningType, Severity severity)
        {
            Id = Guid.NewGuid();
            CleaningType = cleaningType;
            Time = DateTime.Now;
            Severity = severity;
            Purchases = new List<Purchases>();
        }

        public override string ToString()
        {
            return $"Issue Id: {Id} Cleaning Type: {CleaningType} Time: {Time} Severity of Issue: Severity: {Severity}";
        }
    }
}
