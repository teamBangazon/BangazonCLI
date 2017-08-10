using System;
using System.Collections.Generic;
using Bangazon.Models;
using Microsoft.Data.Sqlite;

//Class: ChooseActiveCustomerManager
//Purpose: Presents List of Customer from Database and stores Id of selected customer
//Author: Team One to What
//Properties:
//  activeCustomer: Variable that holds Id of active customer.
//  customers: Holds a list of all customers retrieved from the DB.
//Methods:
//  ListOfCustomers: Queries the DB and adds Customer's id, FirstName and LastName to customers list.
//  ChooseActiveCustomer: Prints list of Customers to the console and reads/saves user input of id as activeCustomer, then loads MainMenu.

namespace Bangazon.Managers
{
    public class ChooseActiveCustomerManager
    {
        public static int activeCustomer;
        public static List<Customer> customers = new List<Customer>();
        public DatabaseInterface db;
        public static List<Customer> ListOfCustomers()
        {   
            DatabaseInterface db = new DatabaseInterface("BANGAZONCLI_DB");
            db.Query("select id, firstname, lastname from customer",
            (SqliteDataReader reader) => {
                customers.Clear();
                while (reader.Read())
                {
                    customers.Add(new Customer(){
                        id = reader.GetInt32(0),
                        FirstName = reader[1].ToString(),
                        LastName = reader[2].ToString()
                    });
                }
            });
            return customers;
        }
        public static void ChooseActiveCustomer()
        {
            var listofcustomers = ListOfCustomers();
            Console.WriteLine("Choose active customer:");
            foreach (Customer customer in listofcustomers)
                {
                    Console.WriteLine($"{customer.id}. {customer.FirstName} {customer.LastName}");
                }
            Console.Write("> ");
            activeCustomer = Int32.Parse(Console.ReadLine());
            Menus.MainMenu();
        }
    }
}