using System;
using System.Collections.Generic;
using Bangazon.Managers;
using Bangazon.Models;

// This "StringBuilder" constitutes the menu for adding a Product.
//User is prompted with a series of options and then is returned to the main menu.


namespace Bangazon.StringBuilders
{

    public class AddProductMenu
    {
        
        public void AddProductStringBuilder(ProductManager SB)
        {
        Product newProduct = new Product();
        Customer newCustomer = new Customer();
        Console.WriteLine ("Enter product name.");
        Console.Write ("> ");
        newProduct.Name = Console.ReadLine();
        Console.WriteLine ("Enter product description.");
        Console.Write ("> ");
        newProduct.Description = Console.ReadLine();
        Console.WriteLine ("Enter product price.");
        Console.Write ("> ");    
        newProduct.Price = Int32.Parse(Console.ReadLine());
        Console.WriteLine ("Enter product type");
        Console.Write ("> ");
        newProduct.ProductType = Console.ReadLine();
        SB.AddProduct(newProduct, newCustomer);
        Menus.MainMenu();
        }
    }
}