using System;
using Bangazon.Models;
using Bangazon.StringBuilders;

//Class: AddProductManager
//Purpose: Creates a new Product Class based on user input
//Author: Team One to What
//Methods:
 //AddProduct: Takes user input and generates new product, sends new product on to string builder



namespace Bangazon.Managers
{
    public class AddProductManager
    {
        public static void AddProduct(AddProductStringBuilder SB)
        {
        Product New = new Product();
        Console.WriteLine ("Enter CustomerId.");
        Console.Write ("> ");
        New.CustomerId = Int32.Parse(Console.ReadLine());
        Console.WriteLine ("Enter product name.");
        Console.Write ("> ");
        New.Name = Console.ReadLine();
        Console.WriteLine ("Enter product description.");
        Console.Write ("> ");
        New.Description = Console.ReadLine();
        Console.WriteLine ("Enter product price.");
        Console.Write ("> ");    
        New.Price = Int32.Parse(Console.ReadLine());
        Console.WriteLine ("Enter product type");
        Console.Write ("> ");
        New.ProductType = Console.ReadLine();   
        
        SB.AddProduct(New);
        Menus.MainMenu();
        }      
    }

}
