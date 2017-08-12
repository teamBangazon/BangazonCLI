using System;
using System.Collections.Generic;
using Bangazon.Models;
using Bangazon.Managers;

// This "StringBuilder" constitutes the menu for adding a Payment Type.
//User is prompted with a series of options and then is returned to the main menu.


namespace Bangazon.StringBuilders
{
    public class AddPaymentTypeMenu
    {
        public void AddPaymentTypeStringBuilder(PaymentTypeManager SB)
        {
        PaymentType paymentType = new PaymentType();
        Customer customer = new Customer();
        Console.WriteLine ("Enter payment method:");
        Console.Write ("> ");
        paymentType.PaymentMethod = Console.ReadLine();
        Console.WriteLine ("Enter account number:");
        Console.Write ("> ");
        paymentType.AccountNumber = Int32.Parse(Console.ReadLine());     
        SB.AddPaymentType(paymentType);
        Menus.MainMenu();
        }      
    }
}