using System;
using Xunit;
using Bangazon.Models;

namespace Bangazon.Tests
{
    public class CustomerShould
    {
        private Customer _customer;

        public CustomerShould()
        {
            _customer = new Customer("Dylan", "Smith", "Warrior Dr", "Murfreesboro", "TN", 37128, "615-481-2667");
        }

        [Fact]
        public void addCustomer()
        {
            Assert.Equal(_customer.FirstName, "Dylan");
            Assert.Equal(_customer.LastName, "Smith");
            Assert.Equal(_customer.Street, "Warrior Dr");
            Assert.Equal(_customer.City, "Murfreesboro");
            Assert.Equal(_customer.State, "TN");
            Assert.Equal(_customer.ZipCode, 37128);
            Assert.Equal(_customer.PhoneNumber, "615-481-2667");
        }

    }
}