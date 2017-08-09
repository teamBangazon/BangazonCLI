using System;
using Bangazon.Models;
using Bangazon.StringBuilders;
using Bangazon.Managers;

//Class: MainMenu
//Purpose: Presents Main Menu
//Author: Team One to What
//Methods:
//  MainMenu: Presents Main Menu and handles routing user to correct menu / manager based on user input

namespace Bangazon
{
   public class Menus
    {
        public static void MainMenu()
        {
            // Seed the database if none exists
            DatabaseInterface db = new DatabaseInterface("BANGAZONCLI_DB");
            db.CheckCustomerTable();
            AddCustomerStringBuilder _ACSB = new AddCustomerStringBuilder(db);

            
            Console.WriteLine ("*************************************************");
            Console.WriteLine ("Welcome to Bangazon! Command Line Ordering System");
            Console.WriteLine ("*************************************************");
            Console.WriteLine ("1. Create a customer account");
            Console.Write ("> ");
            

            // Read in the user's choice
			int choice;
			Int32.TryParse (Console.ReadLine(), out choice);
           
            // If option 1 was chosen, create a new customer account
            if (choice == 1)
            {
             AddCustomerManager.AddCustomer(_ACSB);
            }  
                   
        
        }
    }
}