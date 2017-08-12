using Microsoft.Data.Sqlite;

//Class: CheckCurrentOrdreManager
//Purpose: Checks to see if there is a current order for the active customer
//Author: Team One to What
//Methods:
//  CheckCurrentOrder: Takes user input and generates new product, sends new product on to string builder



namespace Bangazon.Managers
{
    public class CheckCurrentOrderManager
    {
    private DatabaseInterface _db;
    public CheckCurrentOrderManager(DatabaseInterface db)
    {
        _db = db;
    }
        
        public int GetCurrentOrder()
        {   
            int currentOrder = new int();
            DatabaseInterface db = new DatabaseInterface("BANGAZONCLI_DB");
            db.Query($"SELECT * from order WHERE customerID = {ChooseActiveCustomerManager.activeCustomer} AND paymenttypeId = null",
            (SqliteDataReader reader) => {
                while (reader.Read())
                {

                    currentOrder = ;
                }
            });
            return currentOrder;
        }
    }
}