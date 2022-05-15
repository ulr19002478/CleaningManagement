using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningManagement
{
    public class Customer : IPeople
    {
        public Guid Id { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string Contact { get; set; }

        public Customer(string fName, string sName, string contact)
        {
            Id = Guid.NewGuid();
            FName = fName;
            SName = sName;
            Contact = contact;
        }
        public override string ToString()
        {
            return $"Customer Id: {Id} First Name: {FName} Surname: {SName} Contact Number: {Contact}";
        }
    }
}
