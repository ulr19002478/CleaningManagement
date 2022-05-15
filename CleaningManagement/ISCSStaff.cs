using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CleaningManagement.Enums;

namespace CleaningManagement
{
    public interface ISCSStaff
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public StaffType Role { get; set; }
    }
}
