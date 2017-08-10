using System;
using System.Collections.Generic;
using Bangazon.Models;
using Bangazon.Managers;

namespace Bangazon.StringBuilders
{
    public class AddPaymentTypeStringBuilder
    {
    private DatabaseInterface _db;
    public AddPaymentTypeStringBuilder(DatabaseInterface db)
    {
        _db = db; 
    }
        public int AddPaymentType(PaymentType _paytype)
        {
            string paymentTypeString = $"insert into PaymentType values (null, '{ChooseActiveCustomerManager.activeCustomer}', '{_paytype.PaymentMethod}', '{_paytype.AccountNumber}');";
            var Z = _db.Insert(paymentTypeString);
            return Z;
        }
    }
}