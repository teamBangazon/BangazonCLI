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

        [Fact]
        public void GetSellersShould()
        {
            var S = _product.GetSellers(2);
            Assert.IsType<List<Product>>(S);
        }

        [Fact]
        public void CheckIfProdOnOrderShould()
        {
            var P = _product.CheckIfProdOnOrder(1);
            Assert.IsType<bool>(P);
            Assert.True(P);
        }

        [Fact]
        public void DeleteProdShould()
        {
            var D = _product.DeleteProd(9);
            Assert.Equal(9, D);
        }
    }
}