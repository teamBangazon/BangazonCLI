//Class: Customer
//Purpose: Used to store Customer Information
//Author: Team One to What
//Properties:
//  FirstName: Customer First Name
//  LastName: Customer Last Name
//  Street: Customer Street Name
//  City: Customer City
//  State: Customer State
//  ZipCode: Customer Zip Code
//  PhoneNumber: Customer Phone Number

namespace Bangazon.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(string customerFirstName, string customerLastName, string customerStreet, string customerCity, string customerState, int customerZipCode, string customerPhoneNumber)
        {
            FirstName = customerFirstName;
            LastName = customerLastName;
            Street = customerStreet;
            City = customerCity;
            State = customerState;
            ZipCode = customerZipCode;
            PhoneNumber = customerPhoneNumber;
        }

        public Customer()
        {
        }
    }
}