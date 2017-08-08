using System;
using Bangazon.Models;

namespace Bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seed the database if none exists
            DatabaseInterface db = new DatabaseInterface("BANGAZONCLI_DB");
            db.CheckCustomerTable();

            // Present the main menu
           Menus.MainMenu();

			// Read in the user's choice
			int choice;
			Int32.TryParse (Console.ReadLine(), out choice);

            // If option 1 was chosen, create a new customer account
            if (choice == 1)
            {
                Console.WriteLine ("Enter customer first name");
                Console.Write ("> ");
                string FirstName = Console.ReadLine();
                Console.WriteLine ("Enter customer last name");
                Console.Write ("> ");
                string LastName = Console.ReadLine();
                Console.WriteLine ("Enter customer city");
                Console.Write ("> ");
                string City = Console.ReadLine();
                Console.WriteLine ("Enter customer state");
                Console.Write ("> ");
                string State = Console.ReadLine();
                Console.WriteLine ("Enter customer postal code");
                Console.Write ("> ");
                string ZipCode = Console.ReadLine();
                Console.WriteLine ("Enter customer phone number");
                Console.Write ("> ");
                string PhoneNumber = Console.ReadLine();
                Customer manager = new Customer();
            }
        }
    }
}