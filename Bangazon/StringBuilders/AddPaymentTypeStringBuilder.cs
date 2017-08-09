using System;
using System.Collections.Generic;
using Bangazon.Models;

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
            string paymentTypeString = $"INSERT into PaymentType VALUES (null, '{_paytype.PaymentMethod}', '{_paytype.AccountNumber}');";
            var Y = _db.Insert(paymentTypeString);
            return Y;
        }


    }

}