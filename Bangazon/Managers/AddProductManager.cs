using System;
using Bangazon.Models;
using Bangazon.StringBuilders;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

//Class: AddProductManager
//Purpose: Creates a new Product Class based on user input
//Author: Team One to What
//Methods:
//AddProduct: Takes user input and generates new product, sends new product on to string builder



namespace Bangazon.Managers
{
    public class ProductManager
    {
    List<Product> availableProducts = new List<Product>();
    private DatabaseInterface _db;
    public ProductManager(DatabaseInterface db)
    {
        _db = db;
    }
        public int AddProduct(Product _prod, Customer _cust)
        {
            string productString = $"INSERT into Product VALUES (null, '{_prod.Name}', '{_prod.Description}', {_prod.Price}, '{_prod.ProductType}', {ChooseActiveCustomerManager.activeCustomer});";
            var Y = _db.Insert(productString);
            return Y;
        }

        public List<Product> GetAvailable()
        {   
            DatabaseInterface db = new DatabaseInterface("BANGAZONCLI_DB");
            db.Query($"select * from product",
            (SqliteDataReader reader) => {
                availableProducts.Clear();
                while (reader.Read())
                {
                    
                }
            });
            return availableProducts;
        }
    }
}
