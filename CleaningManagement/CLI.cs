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
        //Creates the main object
        static CleaningSystem es = new CleaningSystem("SCS");


        static void Main(string[] args)
        {
            //changes the colour of the sharprompt select and answer
            Prompt.ColorSchema.Answer = ConsoleColor.DarkRed;
            Prompt.ColorSchema.Select = ConsoleColor.DarkRed;
            Console.Clear();

            //Calls the method which starts off the program
            Start();
           
        }

        //ALL METHODS TO DO WITH THE MAIN MENU
        //Method which creates a staff to start off the program
        static void Start()
        {
            Console.Clear(); //Clears the console so no text from other options are still on screen

            var loginOption = Prompt.Select("Start Here", new[] { "Create Staff Account" });
            if (loginOption == "Create Staff Account")
            {
                es.SavedStaff.Add(CreateStaff()); //Creates a staff account
                MainMenu();  //Loads up the main menu after the user has created a staff account             
            }
            else
            {
                return;
            }
        }
        //Main Menu Method
        static void MainMenu()
        {
            
            Console.Clear();//Clears the console so no text from other options are still on screen
            var menuOption = Prompt.Select("Choose an option to Manage", new[] { "Manage Services","Manage People and Properties","Manage Issues" });

            if (menuOption == "Manage Services") //If statement checks which option was picked and where it will lead to
            {
                SelectManageServices(); //Loads up manage services method
                Console.Clear();
            }
            else if (menuOption == "Manage People and Properties")
            {
                SelectPeopandProp(); //Loads up people and property method
                Console.Clear();
            }
            else
            {
                SelectIssues(); //Loads up issues method
                Console.Clear();
            }
        }
        //Method which manages all of the services options
        static void SelectManageServices()
        {
            var Manage = Prompt.Select("Select an option to manage", new[] { "Bookings", "Purchases", "Return to Menu" });
            if(Manage == "Bookings")
            {
                SelectBook(); //Goes to the booking method
                Console.Clear();
            }
            else if(Manage == "Purchases")
            {
                SelectPurchase(); //Goes to the purchases method
                Console.Clear();
            }
            else
            {
                MainMenu(); //Returns to main menu
            }
        }
        //Method used to manage properties and people
        static void SelectPeopandProp()
        {
            var Manage = Prompt.Select("Select an option to manage", new[] { "Staff", "Customers", "Properties" });
            if(Manage == "Staff")
            {
                SelectStaff(); //Goes to the staff method
            }
            else if(Manage == "Customers")
            {
                SelectCustomer(); //Goes to the customer method
            }
            else if(Manage == "Properties")
            {
                SelectProp(); //Goes to the property method
            }
            else
            {
                MainMenu(); //Returns to main menu
            }
        }
        
        //--------------------------------------------------------------------------------
        //ALL METHODS TO DO WITH BOOKING
        //Method to select booking 
        static void SelectBook()
        {
            var book = Prompt.Select("Pick One", new[] { "Create new Booking", "View all Bookings","Go Back", "Return to Menu" });
            if (book == "Create new Booking") //Checks which option has been picked
            {
                es.SavedBookings.Add(CreateBooking());
                Console.Clear(); //Clears the console so no text from other options are still on screen
                SelectBook();
            }
            else if (book == "View all Bookings")
            {
                foreach (var booking in es.SavedBookings) //turns the list into a variable 
                {
                    Console.Clear();
                    Console.WriteLine(booking.ToString()); //outputs the variable created
                    Console.WriteLine("\n"); //line break
                }
                SelectBook();                
            }
            else if(book == "Go Back")
            {
                SelectManageServices();
                Console.Clear();
            }
            else
            {
                MainMenu(); //Returns to main menu
            }
        }

        //Method to create a booking
        static Bookings CreateBooking()
        {
            var details = Prompt.Input<string>("Detail Of the Issue");
            var customer = CreateCustomer();
            es.SavedCustomers.Add(customer);
            return new Bookings(details, customer);
        }

        //--------------------------------------------------------------------------------
        //ALL METHODS TO DO WITH PROPERTY
        //Method called if user chooses the property option
        static void SelectProp()
        {
            var prop = Prompt.Select("Choose an option", new[] { "Add Properties", "View Properties", "Return to Menu" });

            if (prop == "Add Properties")
            {
                var option = Prompt.Select("What type of property do you want to manage", new[] { "Domestic", "Commercial" });
                if (option == "Domestic") //If statement checks what option was picked
                {
                    es.SavedDomestic.Add(CreateDomestic());
                    Console.Clear(); //Clears the console so no text from other options are still on screen
                    SelectProp(); //Returns to the select property method once a new object has been created
                }
                else
                {
                    es.SavedCommercial.Add(CreateCommercial());
                    Console.Clear(); //Clears the console so no text from other options are still on screen
                    SelectProp(); //Returns back to the start of the proeprty
                }
            }
            else if (prop == "View Properties")
            {
                var option = Prompt.Select("What Type of Property would you like to view?", new[] { "Domestic", "Commerical" });
                if (option == "Domestic")
                {
                    foreach (var domproperty in es.SavedDomestic)
                    {
                        Console.WriteLine(domproperty.ToString());
                        Console.WriteLine("\n");
                        
                    }
                    SelectProp();
                }

                else
                {
                    foreach (var comproperty in es.SavedCommercial)
                    {
                        Console.WriteLine(comproperty.ToString());
                        Console.WriteLine("\n");
                        
                    }
                    SelectProp();
                }
            }
            else
            {
                MainMenu(); //Returns to main menu
            }  
        }

        //Method to create a domestic property
        static Domestic CreateDomestic()
        {
            var address = Prompt.Input<string>("Address");
            var type = Prompt.Select<DomesticType>("Select enum value");
            var numOfRooms = Prompt.Input<int>("Number of Rooms");
            var customer = CreateCustomer();
            return new Domestic(address, numOfRooms, type, customer);

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

        //--------------------------------------------------------------------------------
        //ALL METHODS TO DO WITH CUSTOMER
        //Method used when customer is picked
        static void SelectCustomer()
        {
            var customer = Prompt.Select("Choose an option", new[] { "Create new Customer", "View all Customers", "Return to Menu" });
            if (customer == "Create new Customer")
            {
                es.SavedCustomers.Add(CreateCustomer());
                Console.Clear(); //Clears the console so no text from other options are still on screen
                SelectCustomer();
            }
            else if (customer == "View all Customers")
            {
                foreach (var customers in es.SavedCustomers)
                {
                    Console.WriteLine(customers.ToString());
                }
                Console.WriteLine("\n");
                SelectCustomer();
            }
            else
            {
                MainMenu(); //Returns to main menu
            }
        }

        //Method called to create a customer
        static Customer CreateCustomer()
        {
            var fname = Prompt.Input<string>("Firstname");
            var sname = Prompt.Input<string>("Surname");
            var contact = Prompt.Input<String>("Contact");
            return new Customer(fname, sname, contact);
        }

        //--------------------------------------------------------------------------------
        //ALL METHODS TO DO WITH PURCHASES
        //Method used to manage all purchases
        static void SelectPurchase()
        {
            var book = Prompt.Select("Choose an option", new[] { "Add Purchase", "View Purchases","Go Back", "Return to Menu" });
            if (book == "Add Purchase")
            {
                es.SavedPurchases.Add(CreatePurchase());
                Console.Clear(); //Clears the console so no text from other options are still on screen
                SelectPurchase();
            }
            else if (book == "View Purchases")
            {
                foreach (var purchase in es.SavedPurchases)
                {
                    Console.Clear();
                    Console.WriteLine(purchase.ToString());
                    Console.WriteLine("\n");
                    SelectPurchase();  
                }
            }
            else if(book == "Go Back")
            {
                SelectManageServices();
                Console.Clear();
            }
            else
            {
                MainMenu(); //Returns to main menu
            }
        }

        //Method used to store purchases
        static Purchases CreatePurchase()
        {
            var name = Prompt.Input<string>("Item Name");
            var description = Prompt.Input<string>("Item Description");
            var cost = Prompt.Input<double>("Cost");
            var teamMember = CreateStaff();
            return new Purchases(name, description, cost, teamMember);
        }

        //--------------------------------------------------------------------------------
        //ALL METHODS USED FOR CLEANING AND ISSUES
        //Method used to manage all issues
        static void SelectIssues()
        {
            //picks between major issues or cosmetic issues 
            var issues = Prompt.Select("Please choose the type of issue", new [] {"Major", "Cosmetic","Return to Menu"});
            if (issues == "Major")
            {
                Console.Clear(); 
                var mIssue = Prompt.Select("Choose an option", new[] { "Report Issue", "View Issues","Go Back","Return to Menu" });
                if (mIssue == "Report Issue")
                {
                    Console.Clear();
                    es.SavedMIssues.Add(CreateMajor());
                    SelectIssues();
                }
                else if (mIssue == "View Issues")
                {
                    Console.Clear();
                    foreach (var major in es.SavedMIssues)
                    {
                        Console.WriteLine(major.ToString());
                        Console.WriteLine("\n");  
                    }
                    SelectIssues();
                }
                else if(mIssue == "Go Back")
                {
                    SelectIssues(); //goes back to the start of the method
                }
                else
                {
                    MainMenu(); //Returns back to the main menu
                }
            }
            else if(issues == "Cosmetic")
            {
                Console.Clear();
                var cIssue = Prompt.Select("Choose an option", new[] { "Report Issue", "View Issues","Go Back", "Return to Menu" });
                if (cIssue == "Report Issue")
                {
                    Console.Clear();
                    es.SavedCIssues.Add(CreateCosmetic());
                    SelectIssues();
                }
                else if (cIssue == "View Issues")
                {
                    Console.Clear();
                    foreach (var cosmetic in es.SavedCIssues)
                    {
                        Console.WriteLine(cosmetic.ToString());
                        Console.WriteLine("\n"); 
                    }
                    SelectPurchase();
                }
                else if (cIssue == "Go Back")
                {
                    SelectIssues();
                }
            }
            else
            {
                MainMenu(); //Returns to main menu
            }
        }

        //Method used to create a major cleaning issue
        static Major CreateMajor()
        {
            var issueName = Prompt.Input<string>("Issue Name");
            var severity = Prompt.Select<Severity>("Major Issue Severity");
            var customer = CreateCustomer();
            return new Major(issueName, severity, customer);
        }

        //Method used to create a cosmetic cleaning issue
        static Cosmetic CreateCosmetic()
        {
            var issueName = Prompt.Input<string>("Issue Name");
            var customer = CreateCustomer();
            return new Cosmetic(issueName, customer);
        }

        //ALL METHODS TO DO WITH STAFF
        //Method used to manage all the staff
        static void SelectStaff()
        {
            var staffOption = Prompt.Select("Choose an option", new[] { "Create Staff Member", "View Staff Members", "Return to Menu" });
            if (staffOption == "Create Staff Member")
            {
                Console.Clear(); 
                es.SavedStaff.Add(CreateStaff());
                SelectStaff();
            }
            else if (staffOption == "View Staff Members")
            {
                Console.Clear();
                foreach (var members in es.SavedStaff)
                {
                    Console.WriteLine(members.ToString());
                    Console.WriteLine("\n");
                    SelectStaff();
                }
            }
            else
            {
                MainMenu(); //Returns to main menu
            }
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
    }
}
