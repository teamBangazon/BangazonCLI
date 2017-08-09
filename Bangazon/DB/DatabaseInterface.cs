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
                            `zipcode`     interger not null,
                            `phonenumber`   string not null
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
