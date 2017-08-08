using System;
using System.Collections.Generic;
using Bangazon.Models;

namespace Bangazon
{
    public class AddCustomerStringBuilder
    {
    private DatabaseInterface _db;
    public AddCustomerStringBuilder()
    {
        _db = new DatabaseInterface("BANGAZONCLI_DB");
    }
        public int AddCustomer(Customer _custy)
        {
            string customerString = $"INSERT into Customer VALUES (null, '{_custy.FirstName}', '{_custy.LastName}', '{_custy.Street}', '{_custy.City}', '{_custy.State}', '{_custy.ZipCode}', '{_custy.PhoneNumber}');";
            //INSERT into Customer VALUES ( null, "Dylan", "Smith", "Warrior Dr", "Murfreesboro",  37128 , "615-481-2667");
            var Y = _db.Insert(customerString);
             Console.WriteLine(customerString);
            return Y;
        }


    }

}