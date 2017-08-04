using System;
using Xunit;
using Bangazon.Models;

namespace Bangazon.Tests
{
    public class ProductShould
    {
        private Product _product;

        public ProductShould()
        {
            _product = new Product(1, "Cheese Nip", "Crunchy cheese cracker", 3.00, "Food");
        }

        [Fact]
        public void addProduct()
        {
            Assert.Equal(_product.CustomerId, 1);
            Assert.Equal(_product.Name, "Cheese Nip");
            Assert.Equal(_product.Description, "Crunchy cheese cracker");
            Assert.Equal(_product.Price, 3.00);
            Assert.Equal(_product.ProductType, "Food");
        }

    }
}