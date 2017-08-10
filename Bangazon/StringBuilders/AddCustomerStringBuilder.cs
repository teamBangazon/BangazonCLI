using System;
using System.Collections.Generic;
using Bangazon.Managers;
using Bangazon.Models;

//


namespace Bangazon.StringBuilders
{
    public class AddCustomerMenu
    {
        public void AddCustomerStringBuilder(CustomerManager SB)
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