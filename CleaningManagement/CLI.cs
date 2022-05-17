using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharprompt;
using static CleaningManagement.Enums;

namespace CleaningManagement
{
    public static class CLI
    {
        static CleaningSystem es = new CleaningSystem("SCS");
        static void Main(string[] args)
        {
            Console.Clear();

            var prop = Prompt.Select("What type of property do you want to manage: ", new[] { "Domestic", "Commercial" });



            if(prop == "Domestic")
            {
                CreateDomestic();
            }
            else
            {
                CreateCommercial();
            }
        }

        static Domestic CreateDomestic()
        {
            var address = Prompt.Input<string>("Address");
            var type = Prompt.Select<DomesticType>("Select enum value");
            var numOfBedrooms = Prompt.Input<int>("Number of bedrooms");

            var customer = CreateCustomer();

            Domestic res = new Domestic(address, numOfBedrooms ,type, customer);
            es.Properties.Add(res);
            return res;

        }
        static Commercial CreateCommercial()
        {
            var address = Prompt.Input<string>("Address");
            var type = Prompt.Select<CommercialType>("Select enum value");
            var size = Prompt.Input<int>("Size of the Property in sq. ft");

            var customer = CreateCustomer();

            Commercial res = new Commercial(address, size, type, customer);
            es.Properties.Add(res);
            return res;
        }
        static Customer CreateCustomer()
        {
            var fname = Prompt.Input<string>("Firstname");
            var sname = Prompt.Input<string>("Surname");
            var contact = Prompt.Input<String>("Contact");
            return new Customer(fname, sname, contact);
        }
    }
}
