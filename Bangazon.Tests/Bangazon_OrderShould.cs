using Xunit;
using Bangazon.Models;
using System;
using System.Collections.Generic;

namespace Bangazon.Tests
{
    public class OrderShould
    {
        private Order _order;

        public OrderShould()
        {
            _order = new Order(1);
            _order.PaymentTypeId = 1;
        }

        [Fact]
        public void addOrder()
        {        
            _order.ProductIdList.Add(1);
            _order.ProductIdList.Add(2);
            _order.ProductIdList.Add(3);
            Assert.Equal(_order.CustomerId, 1);
            Assert.Equal(_order.PaymentTypeId, 1);
            Assert.IsType<List<int>>(_order.ProductIdList);
            var test_ProductIdList = new List<int>(){1,2,3};
            Assert.Equal(_order.ProductIdList, test_ProductIdList); 
        }

        
    }


}