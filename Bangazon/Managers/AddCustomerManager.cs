using System;
using Bangazon.Models;
using Bangazon.StringBuilders;

//Class: AddCustomerManager
//Purpose: Creates a new Customer Class based on user input
//Author: Team One to What
//Methods:
//  AddCustomer: Takes user input and generates new customer and then sends new customer on to string builder



namespace Bangazon.Managers
{
    public class CustomerManager
    {
    private DatabaseInterface _db;
    public CustomerManager(DatabaseInterface db)
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
