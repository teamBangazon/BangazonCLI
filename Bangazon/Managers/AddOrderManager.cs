using System;
using Bangazon;
using Bangazon.Models;
using Microsoft.Data.Sqlite;

//Class: OrderManager
//Purpose: 
//Author: Team One to What
//Properties:
//  currentOrder: nullable int to allow null assignment until completion of order
//Methods:
//  AddProductToOrder: Parameter(productId and activeCustomer) uses active customer to call GetCurrentOrder, identifying orderId to be added with productId to new OrderProduct
//  CheckCurrentOrder: Checks to see if there is a current order for the active customer. Takes user input and generates new product, sends new product on to string builder

namespace Bangazon.Managers
{
    public class OrderManager
    {
        public DatabaseInterface db;
        public static int? currentOrder;
        public static int AddProductToOrder(int productId, int activeCustomer)
        {   
            DatabaseInterface db = new DatabaseInterface("BANGAZONCLI_DB");
            GetCurrentOrder(activeCustomer);
            var newOrderProductId = db.Insert($"insert into orderproduct values(null, {currentOrder}, {productId})");
            
            return newOrderProductId;
        }
        public static int? GetCurrentOrder(int customerid)
        {   
            currentOrder = null;
            DatabaseInterface db = new DatabaseInterface("BANGAZONCLI_DB");
            db.Query($"SELECT `order`.id FROM `order` WHERE `order`.customerid IS {customerid} AND `order`.paymenttypeid IS null",
            (SqliteDataReader reader) => {
                while (reader.Read())
                {
                    currentOrder = reader.GetInt32(0);
                }
            });
            if (currentOrder != null)
            {
                return currentOrder;
            }
            else
            {
                currentOrder = db.Insert($"insert into `order` values(null, null, {customerid})");
                Console.WriteLine("new order created");
                return currentOrder;
            }
        
        }    
            
    }
}