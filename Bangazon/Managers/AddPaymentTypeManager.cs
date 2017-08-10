using System;
using Bangazon.Models;
using Bangazon.StringBuilders;

// Class: AddPaymentTypeManager
// Purpose: Creates a new Payment Type Class based on user input
// Author: Team One to What - Kathy Weisensel
// Methods:
//  AddPaymentType: Takes user input and generates new payment type and then sends new payment type on to string builder

namespace Bangazon.Managers
{
    public class AddPaymentTypeManager
    {
        public static void AddPaymentType(AddPaymentTypeStringBuilder SB)
        {
        PaymentType New = new PaymentType();  
        New.id = ChooseActiveCustomerManager.activeCustomer;
        Console.WriteLine ("Enter payment method:");
        Console.Write ("> ");
        New.PaymentMethod = Console.ReadLine();
        Console.WriteLine ("Enter account number:");
        Console.Write ("> ");
        New.AccountNumber = Int32.Parse(Console.ReadLine());     
        SB.AddPaymentType(New);
        Menus.MainMenu();
        }      
    }

}