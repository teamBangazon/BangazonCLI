using System;
using System.Collections.Generic;
using Bangazon.Models;

namespace Bangazon.StringBuilders
{
    public class AddCustomerStringBuilder
    {
    private DatabaseInterface _db;
    public AddCustomerStringBuilder(DatabaseInterface db)
    {
        _db = db;
    }
        public int AddCustomer(Customer _custy)
        {
            string customerString = $"INSERT into Customer VALUES (null, '{_custy.FirstName}', '{_custy.LastName}', '{_custy.Street}', '{_custy.City}', '{_custy.State}', '{_custy.ZipCode}', '{_custy.PhoneNumber}');";
            var Y = _db.Insert(customerString);
            return Y;
        }
    }
}