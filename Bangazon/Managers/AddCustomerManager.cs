using System;
using Bangazon.Models;
using Bangazon.StringBuilders;

//Class: AddCustomerManager
//Purpose: Creates a new Customer Class based on user input
//Author: Team One to What
//Methods:
//  AddCustomer: Takes user input and generates new customer and then sends new customer on to string builder



namespace Bangazon.Managers
{
    public class AddCustomerManager
    {
        public static void AddCustomer(AddCustomerStringBuilder SB)
        {
        Customer New = new Customer();  
        Console.WriteLine ("Enter customer first name");
        Console.Write ("> ");
        New.FirstName = Console.ReadLine();
        Console.WriteLine ("Enter customer last name");
        Console.Write ("> ");
        New.LastName = Console.ReadLine();
        Console.WriteLine ("Enter customer Street");
        Console.Write ("> ");    
        New.Street = Console.ReadLine();
        Console.WriteLine ("Enter customer City");
        Console.Write ("> ");
        New.City = Console.ReadLine();
        Console.WriteLine ("Enter customer State");
        Console.Write ("> ");
        New.State = Console.ReadLine();
        Console.WriteLine ("Enter customer postal code");
        Console.Write ("> ");
        New.ZipCode = Int32.Parse(Console.ReadLine());
        Console.WriteLine ("Enter customer phone number");
        Console.Write ("> ");
        New.PhoneNumber = Console.ReadLine();     
        SB.AddCustomer(New);
        Menus.MainMenu();
        }      
    }

}
