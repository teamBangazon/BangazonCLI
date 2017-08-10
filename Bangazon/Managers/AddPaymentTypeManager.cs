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
    public class PaymentTypeManager
    {
    private DatabaseInterface _db;
    public PaymentTypeManager(DatabaseInterface db)
    {
        _db = db; 
    }
        public int AddPaymentType(PaymentType _paytype)
        {
            string paymentTypeString = $"insert into PaymentType values (null, {_paytype.AccountNumber}, '{_paytype.PaymentMethod}', '{ChooseActiveCustomerManager.activeCustomer}');";
            var Z = _db.Insert(paymentTypeString);
            return Z;
        }
    }

}
