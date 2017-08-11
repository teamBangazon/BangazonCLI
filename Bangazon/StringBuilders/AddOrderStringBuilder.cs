using System;
using System.Collections.Generic;
using Bangazon.Models;
using Bangazon.Managers;

namespace Bangazon.StringBuilders
{
    public class AddOrderMenu
    {

        // add product to customer's cart
        public void AddOrderStringBuilder(OrderManager SB)
        {
        Order order = new Order();
        var counter = 1;
        Console.Clear();
        Console.WriteLine ("Choose Product:");
        List<Product>products = null;
        // add function once it is created to pull list of products here
        foreach (var product in products)
            {
                Console.WriteLine($"{counter++} {product.Name}");
            }
        Console.WriteLine($"Press {counter} to quit");
        Console.Write ("> ");  
        SB.AddOrder(order);
        Menus.MainMenu();
        }      
    }
}