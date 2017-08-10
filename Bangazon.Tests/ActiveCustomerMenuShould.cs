using System.Collections.Generic;
using Bangazon.Models;
using Bangazon.Managers;
using Xunit;

namespace Bangazon.Tests
{
    public class ActiveCustomerMenuShould
    {        

        [Fact]
        public void QueryShouldReturnListofCustomers()
        {   
            ChooseActiveCustomerManager.activeCustomer = 12;
            var returnedList = ChooseActiveCustomerManager.ListOfCustomers();
            Assert.IsType<List<Customer>>(returnedList);
            Assert.Equal(12, ChooseActiveCustomerManager.activeCustomer);
        }
    }
}