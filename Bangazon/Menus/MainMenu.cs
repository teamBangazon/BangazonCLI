using System;
using Bangazon.Models;


namespace Bangazon
{
   public class Menus
    {
        public static void MainMenu()
        {
            Console.WriteLine ("*************************************************");
            Console.WriteLine ("Welcome to Bangazon! Command Line Ordering System");
            Console.WriteLine ("*************************************************");
            Console.WriteLine ("1. Create a customer account");
            Console.Write ("> ");
        }
    }
}