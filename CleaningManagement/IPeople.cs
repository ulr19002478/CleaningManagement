using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningManagement
{
    public interface IPeople
    {
        public Guid Id { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string Contact { get; set; }
    }
}
