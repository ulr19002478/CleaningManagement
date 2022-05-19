using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningManagement
{
    public interface ICleaning
    {
        public Guid Id { get; set; }
        public String CleaningType { get; set; }
        public DateTime Time { get; set; }
        public List<Purchases> Purchases { get; set;}

        public Customer Customer { get; set; }    
    }
}
