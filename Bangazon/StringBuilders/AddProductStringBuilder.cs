using System;
using System.Collections.Generic;
using Bangazon.Managers;
using Bangazon.Models;

//


namespace Bangazon.StringBuilders
{

    public class AddProductMenu
    {
        
        public void AddProductStringBuilder(ProductManager SB)
        {
        Product newProduct = new Product();
        Customer newCustomer = new Customer();
        //newProduct.CustomerId = ChooseActiveCustomerManager.activeCustomer;
        // Console.WriteLine ("Enter CustomerId.");
        // Console.Write ("> ");
        // newProduct.CustomerId = Int32.Parse(Console.ReadLine());
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