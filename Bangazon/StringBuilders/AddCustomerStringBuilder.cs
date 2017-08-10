using System;
using System.Collections.Generic;
using Bangazon.Managers;
using Bangazon.Models;

namespace Bangazon.StringBuilders
{
    public class AddCustomerMenu
    {
        public void AddCustomerStringBuilder(CustomerManager SB)
        {
        Customer customer = new Customer();  
        Console.WriteLine ("Enter customer first name");
        Console.Write ("> ");
        customer.FirstName = Console.ReadLine();
        Console.WriteLine ("Enter customer last name");
        Console.Write ("> ");
        customer.LastName = Console.ReadLine();
        Console.WriteLine ("Enter customer Street");
        Console.Write ("> ");    
        customer.Street = Console.ReadLine();
        Console.WriteLine ("Enter customer City");
        Console.Write ("> ");
        customer.City = Console.ReadLine();
        Console.WriteLine ("Enter customer State");
        Console.Write ("> ");
        customer.State = Console.ReadLine();
        Console.WriteLine ("Enter customer postal code");
        Console.Write ("> ");
        customer.ZipCode = Int32.Parse(Console.ReadLine());
        Console.WriteLine ("Enter customer phone number");
        Console.Write ("> ");
        customer.PhoneNumber = Console.ReadLine();     
        SB.AddCustomer(customer);
        Menus.MainMenu();
        }      
    }
}