using System;
using Bangazon.Models;
using Bangazon.StringBuilders;
using Xunit;

namespace Bangazon.Tests
{
    public class AddProductStringBuilderShould
    {
        private readonly DatabaseInterface _db;

        private AddProductStringBuilder _product;

        public AddProductStringBuilderShould()
        {
            _db = new DatabaseInterface("BANGAZONCLI_DB");
            _db.CheckProductTable();
            _product = new AddProductStringBuilder(_db);
        }
    }
}