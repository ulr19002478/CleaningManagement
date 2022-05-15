using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CleaningManagement.Enums;

namespace CleaningManagement
{
    public class TeamMember : IPeople, ISCSStaff
    {
        public Guid Id { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string Contact { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public StaffType Role { get; set; }

        public TeamMember(string fName, string sName, string contact, string username, string password, StaffType role)
        {
            Id = Guid.NewGuid();
            FName = fName;
            SName = sName;
            Contact = contact;
            Username = username;
            Password = password;
            Role = role;
        }
        public override string ToString()
        {
            return $"Staff Id: {Id} First Name: {FName} Surname: {SName} Contact Number: {Contact} Username: {Username} Password: {Password} Position: {Role}";
        }
    }
}
