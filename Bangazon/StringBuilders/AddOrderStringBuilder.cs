using System;
using System.Collections.Generic;
using Bangazon.Models;
using Bangazon.Managers;

namespace Bangazon.StringBuilders
{
    public class AddOrderMenu
    {
        //private ProductManager _pm;

        // add product to customer's cart
        public void AddOrderStringBuilder(ProductManager _pm)
        {
         Console.Clear();   
        int X;
        Order order = new Order();
        order.CustomerId = ChooseActiveCustomerManager.activeCustomer;
        var counter = 1;
        Console.Clear();
        Console.WriteLine ("Choose Product:");
        List<Product>products = null;
        // function to pull list of products to loop through
        products = _pm.GetAvailable();
        foreach (var product in products)
            {
                Console.WriteLine($"{product.id}. {product.Name}");
                counter++;
            }
        Console.WriteLine($"Press {counter} to quit");
        Console.Write ("> "); 
        X = Int32.Parse(Console.ReadLine()); 
        if (X == counter)
        {
           Menus.MainMenu();
        }
        //SB.AddOrder(order);
        Menus.MainMenu();
        }      
    }
}