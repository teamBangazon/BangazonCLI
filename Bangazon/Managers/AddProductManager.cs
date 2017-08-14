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
    List<Product> sellersProducts = new List<Product>();
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
                    availableProducts.Add(new Product(){
                        id = reader.GetInt32(0),
                        Name = reader[1].ToString(),
                        Description = reader[2].ToString(),
                        Price = reader.GetInt32(3),
                        ProductType = reader[4].ToString()
                    });
                }
            });
            return availableProducts;
        }

        public List<Product> GetSellers(int customerid)
        {
            DatabaseInterface db = new DatabaseInterface("BANGAZONCLI_DB");
            db.Query($"select product.id, product.name from product where product.customerid = {customerid}",
            (SqliteDataReader reader) => {
                sellersProducts.Clear();
                while(reader.Read())
                {
                    sellersProducts.Add(new Product(){
                        id = reader.GetInt32(0),
                        Name = reader[1].ToString()
                    });
                }
            });
            return sellersProducts;
        }

        public bool? CheckIfProdOnOrder(int productid)
        {   
            bool? ProdOnOrder = null;
            DatabaseInterface db = new DatabaseInterface("BANGAZONCLI_DB");
            db.Query($"select orderproduct.productId, product.customerId, `order`.paymenttypeid from product join orderproduct on orderproduct.productId = product.id and product.id = {productid} join `order` where orderproduct.orderId is `order`.id;",
            (SqliteDataReader reader) => {
                if (reader.HasRows)
                {
                    ProdOnOrder = true;
                }
                else
                {
                    ProdOnOrder = false;
                }
            });
            return ProdOnOrder;
        }

        public int DeleteProd(int productid)
        {
            int deletedprod = 0;
            DatabaseInterface db = new DatabaseInterface("BANGAZONCLI_DB");
            db.Query($"select product.id, product.name from product where product.id = {productid}",
            (SqliteDataReader reader) => {
                while(reader.Read())
                {
                    deletedprod = reader.GetInt32(0);
                }
            });
            db.Delete($"delete from product where product.id is {productid}");
            return deletedprod;
        }
    }
}
