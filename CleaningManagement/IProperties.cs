using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningManagement
{
    public interface IProperties
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public List<ICleaning> Issues { get; set; }
    }
}
