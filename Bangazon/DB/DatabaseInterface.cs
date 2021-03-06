using System;
using Microsoft.Data.Sqlite;

//Class: Database Interface
//Purpose: Accepts SQL formatted strings and Interacts directly with SQL database
//Author: Team One to What
//Methods:
//  Query: Handles SQL SELECT calls
//  Insert: Handles SQL INSERT calls
//  CheckCustomerTable: Checks to see if Customer Table Exists and creates it if not.


namespace Bangazon
{
    public class DatabaseInterface
    {
        private string _connectionString;
        private SqliteConnection _connection;
        public DatabaseInterface(string database)
        {
            string env = $@"{Environment.GetEnvironmentVariable(database)}";
            _connectionString = $"Data Source={env}";
            _connection = new SqliteConnection(_connectionString);
        }

        
        public void Query(string command, Action<SqliteDataReader> handler)
        {
            using (_connection)
            {
                _connection.Open();
                SqliteCommand dbcmd = _connection.CreateCommand();
                dbcmd.CommandText = command;

                using (SqliteDataReader dataReader = dbcmd.ExecuteReader())
                {
                    handler (dataReader);
                }

                dbcmd.Dispose();
                _connection.Close();
            }
        }

        public int Insert(string command)
        {
            int insertedItemId = 0;

            using (_connection)
            {
                _connection.Open();
                SqliteCommand dbcmd = _connection.CreateCommand();
                dbcmd.CommandText = command;

                dbcmd.ExecuteNonQuery();

                this.Query("select last_insert_rowid()",
                    (SqliteDataReader reader) => {
                        while (reader.Read())
                        {
                            insertedItemId = reader.GetInt32(0);
                        }
                    }
                );

                dbcmd.Dispose();
                _connection.Close();
            }
            return insertedItemId;
        }

        public void Delete(string command)
        {

            using (_connection)
            {
                _connection.Open();
                SqliteCommand dbcmd = _connection.CreateCommand();
                dbcmd.CommandText = command;
                dbcmd.ExecuteNonQuery();
                dbcmd.Dispose();
                _connection.Close();
            }
        }
        
        public void CheckCustomerTable()
        {
            using (_connection)
            {
                _connection.Open();
                SqliteCommand dbcmd = _connection.CreateCommand();

                dbcmd.CommandText = $@"select id from customer";

                try
                {
                    using (SqliteDataReader reader = dbcmd.ExecuteReader())
                    {
                        Console.WriteLine("reading db, tbl should exist");
                    }
                    dbcmd.Dispose();
                }
                catch (Microsoft.Data.Sqlite.SqliteException ex)
                {
                    Console.WriteLine(ex.Message);
                    if (ex.Message.Contains("no such table"))
                    {
                        dbcmd.CommandText = $@"create table customer (
                            `id`        integer NOT NULL PRIMARY KEY AUTOINCREMENT,
                            `firstname` string not null,
                            `lastname`  string not null,
                            `street`    string not null,
                            `city`      string not null,
                            `state`      string not null,
                            `zipcode`     integer not null,
                            `phonenumber`   string not null
                        )";
                        dbcmd.ExecuteNonQuery();
                        dbcmd.Dispose();
                    }
                }
                _connection.Close();
            }
        }
        public void CheckPaymentTypeTable()
        {
            using (_connection)
            {
                _connection.Open();
                SqliteCommand dbcmd = _connection.CreateCommand();

                dbcmd.CommandText = $@"select id from PaymentType";

                try
                {
                    using (SqliteDataReader reader = dbcmd.ExecuteReader())
                    {
                        Console.WriteLine("payment type table should exist");
                    }
                    dbcmd.Dispose();
                }
                catch (Microsoft.Data.Sqlite.SqliteException ex)
                {
                    Console.WriteLine(ex.Message);
                    if (ex.Message.Contains("no such table"))
                    {
                        dbcmd.CommandText = $@"create table PaymentType (
                            `id` integer NOT NULL PRIMARY KEY AUTOINCREMENT,
                            `PaymentMethod` string NOT NULL,
                            `AccountNumber` integer NOT NULL,
                            `CustomerId` integer NOT NULL,
                             FOREIGN KEY(`CustomerId`) REFERENCES `customer`(`id`)
                        )";
                        dbcmd.ExecuteNonQuery();
                        dbcmd.Dispose();
                    }
                }
                _connection.Close();
            }
        }
        public void CheckProductTable()
        {
            using (_connection)
            {
                _connection.Open();
                SqliteCommand dbcmd = _connection.CreateCommand();

                dbcmd.CommandText = $@"select id from product";

                try
                {
                    using (SqliteDataReader reader = dbcmd.ExecuteReader())
                    {
                        Console.WriteLine("reading db, tbl should exist");
                    }
                    dbcmd.Dispose();
                }
                catch (Microsoft.Data.Sqlite.SqliteException ex)
                {
                    Console.WriteLine(ex.Message);
                    if (ex.Message.Contains("no such table"))
                    {
                        dbcmd.CommandText = $@"create table product (
                            `id`    integer NOT NULL PRIMARY KEY AUTOINCREMENT,
                            `name`  string not null,
                            `description`   string not null,
                            `price`    string not null,
                            `producttype`   string not null,
                            `customerId` integer not null,
                             FOREIGN KEY(`customerId`) REFERENCES `customer`(`id`)
                        )";
                        dbcmd.ExecuteNonQuery();
                        dbcmd.Dispose();
                    }
                }
                _connection.Close();
            }
        }
      
        public void CheckOrderTable()
        {
            using (_connection)
            {
                _connection.Open();
                SqliteCommand dbcmd = _connection.CreateCommand();

                dbcmd.CommandText = $@"select id from `order`";

                try
                {
                    using (SqliteDataReader reader = dbcmd.ExecuteReader())
                    {
                        Console.WriteLine("reading db, order tbl should exist");
                    }
                    dbcmd.Dispose();
                }
                catch (Microsoft.Data.Sqlite.SqliteException ex)
                {
                    Console.WriteLine(ex.Message);
                    if (ex.Message.Contains("no such table"))
                    {
                        dbcmd.CommandText = $@"create table `order` (
                            `id`    integer NOT NULL PRIMARY KEY AUTOINCREMENT,
                            `paymenttypeid`   integer,
                            `customerId` integer not null,
                             FOREIGN KEY(`paymenttypeid`) REFERENCES `paymenttype`(`id`),
                             FOREIGN KEY(`customerId`) REFERENCES `customer`(`id`)
                        )";
                        dbcmd.ExecuteNonQuery();
                        dbcmd.Dispose();
                    }
                }
                _connection.Close();
            }
        }


         public void CheckOrderProductTable()
        {
            using (_connection)
            {
                _connection.Open();
                SqliteCommand dbcmd = _connection.CreateCommand();

                dbcmd.CommandText = $@"select id from orderproduct";


                try
                {
                    using (SqliteDataReader reader = dbcmd.ExecuteReader())
                    {

                        Console.WriteLine("reading db, orderproduct tbl should exist");

                    }
                    dbcmd.Dispose();
                }
                catch (Microsoft.Data.Sqlite.SqliteException ex)
                {
                    Console.WriteLine(ex.Message);
                    if (ex.Message.Contains("no such table"))
                    {

                        dbcmd.CommandText = $@"create table orderproduct (
                            `id` integer NOT NULL PRIMARY KEY AUTOINCREMENT,
                            `orderId`  integer not null,
                            `productId` integer not null,
                             FOREIGN KEY(`productId`) REFERENCES `product`(`id`)
                             FOREIGN KEY(`orderId`) REFERENCES `order`(`id`)
                        )";
                        dbcmd.ExecuteNonQuery();
                        dbcmd.Dispose();
                    }
                }
                _connection.Close();
            }
        }
    }
} 
