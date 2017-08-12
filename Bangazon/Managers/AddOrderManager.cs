using Bangazon.Models;
using Microsoft.Data.Sqlite;

namespace Bangazon.Managers
{
    public class OrderManager
    {
        public DatabaseInterface db;

        public static int AddProductToOrder(Product product)
        {   
            DatabaseInterface db = new DatabaseInterface("BANGAZONCLI_DB");
            // db.Query("select id, ")
            return 3;
        }
        public static bool DoesOrderExist(int customerid)
        {   
            DatabaseInterface db = new DatabaseInterface("BANGAZONCLI_DB");
            int? activeOrder = null;
            db.Query($"select order.id from `order` where order.customerid is {customerid} and order.paymenttypeid is 'null'",
            (SqliteDataReader reader) => {
                while (reader.Read())
                {
                    activeOrder = reader.GetInt32(0);
                }
            });
            if (activeOrder != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }    
            
    }
}