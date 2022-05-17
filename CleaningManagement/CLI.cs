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


            MainMenu();


        }

        static void MainMenu()
        {
            //Main Menu
            var menuOption = Prompt.Select("\nWhere would you like to go: \n", new[] { "Properties", "Bookings", "Customers", "Purchases", "Cleaning Issues" });

            if (menuOption == "Properties")
            {
                SelectProp();
            }
            else if (menuOption == "Bookings")
            {
                SelectBook();
            }
        }

        static void SelectBook()
        {
            var book = Prompt.Select("Pick One", new[] { "Create new Booking", "View all Bookings","Return to Menu" });
            if(book == "Create new Booking")
            {
                es.SavedBookings.Add(CreateBooking());
            }
            else if(book == "View all Bookings")
            {
                foreach (var booking in es.SavedBookings)
                {
                    Console.WriteLine(booking.ToString());
                }
            }
            else
            {
                SelectBook();
            }

            MainMenu();
        }
        //Method called if user chooses the property option
        static void SelectProp()
        {
            var prop = Prompt.Select("What type of property do you want to manage", new[] { "Domestic", "Commercial" });


            //checks which option you picked
            if(prop == "Domestic")
            {
                CreateDomestic();
            }
            else
            {
                CreateCommercial();
            }
        }
        //Method to create a domestic property
        static Domestic CreateDomestic()
        {
            var address = Prompt.Input<string>("Address");
            var type = Prompt.Select<DomesticType>("Select enum value");
            var numOfRooms = Prompt.Input<int>("Number of Rooms");

            var customer = CreateCustomer();

            Domestic res = new Domestic(address, numOfRooms ,type, customer);
            es.Properties.Add(res);
            return res;

        }
        //Method called to create a commercial property
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
        //Method called to create a customer
        static Customer CreateCustomer()
        {
            var fname = Prompt.Input<string>("Firstname");
            var sname = Prompt.Input<string>("Surname");
            var contact = Prompt.Input<String>("Contact");
            return new Customer(fname, sname, contact);
        }
        //Method used to create a team member
        static TeamMember CreateStaff()
        {
            var fname = Prompt.Input<string>("Firstname");
            var sname = Prompt.Input<string>("Surname");
            var contact = Prompt.Input<string>("Contact");
            var username = Prompt.Input<string>("Username");
            var secret = Prompt.Password("Type New Password");
            var position = Prompt.Select<StaffType>("Select Position");
            return new TeamMember(fname, sname, contact, username, secret, position);
        }

        static Bookings CreateBooking()
        {
            var details = Prompt.Input<string>("Detail Of the Issue");
            var customer = CreateCustomer();

            return new Bookings(details,customer);
            
        }

    }
}
