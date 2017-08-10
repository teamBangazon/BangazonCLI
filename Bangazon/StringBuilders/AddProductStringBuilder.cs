using System;
using System.Collections.Generic;
using Bangazon.Models;

//


namespace Bangazon.StringBuilders
{
    public class AddProductStringBuilder
    {
    private DatabaseInterface _db;
    public AddProductStringBuilder(DatabaseInterface db)
    {
        _db = db;
    }
        public int AddProduct(Product _prod)
        {
            string productString = $"INSERT into Product VALUES ('{_prod.CustomerId}', '{_prod.Name}', '{_prod.Description}', '{_prod.Price}', '{_prod.ProductType}');";
            var Y = _db.Insert(productString);
            return Y;
        }


    }

}