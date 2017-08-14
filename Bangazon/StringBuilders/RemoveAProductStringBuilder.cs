using System;
using Bangazon.Managers;

namespace Bangazon.StringBuilders
{
    public class RemoveProductMenu
    {
        public void RemoveAProductStringBuilder(ProductManager productManager)
        {
            Console.Clear();
            int PID;
            StartDel:
            Console.WriteLine("Choose a product to delete:");
            var products = productManager.GetSellers(ChooseActiveCustomerManager.activeCustomer);
            foreach (var product in products)
            {
                Console.WriteLine($"{product.id}. {product.Name}");
            }
            Console.Write("> ");
            PID = Int32.Parse(Console.ReadLine());
            if(productManager.CheckIfProdOnOrder(PID) == true)
            {
                Console.WriteLine("Item has been ordered, unable to delete");
                Console.WriteLine("Return to main menu Y/N?");
                
                if(Console.ReadLine() == "Y" || Console.ReadLine() == "y")
                {
                    Menus.MainMenu();
                }
                if(Console.ReadLine() == "N" || Console.ReadLine() == "n")
                {
                    goto StartDel;
                }
            }
            else
            {
                Console.WriteLine("Can be deleted");
                goto StartDel;

            }
        }
    }
}