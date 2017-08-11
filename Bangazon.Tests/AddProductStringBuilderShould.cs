using System;
using Bangazon.Managers;
using Bangazon.Models;
using Bangazon.StringBuilders;
using System.Collections.Generic;
using Xunit;

namespace Bangazon.Tests
{
    public class AddProductStringBuilderShould
    {
        private readonly DatabaseInterface _db;

        private ProductManager _product;

        public AddProductStringBuilderShould()
        {
            _db = new DatabaseInterface("BANGAZONCLI_DB");
            _db.CheckProductTable();
            _product = new ProductManager(_db);
        }

        [Fact]
        public void GetAvailableshould()
        {
            var Z = _product.GetAvailable();
            Assert.IsType<List<Product>>(Z);
        }
    }
}