using System;
using System.Collections.Generic;
using Bangazon.Models;
using Bangazon.Managers;

namespace Bangazon.StringBuilders
{
    public class AddPaymentTypeMenu
    {
        public void AddPaymentTypeStringBuilder(PaymentTypeManager SB)
        {
        PaymentType paymentType = new PaymentType();
        Customer customer = new Customer();
        //paymentType.CustomerId = ChooseActiveCustomerManager.activeCustomer;
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