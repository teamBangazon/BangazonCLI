# Bangazon Platform CLI - Team Bangazon

The Bangazon Command Line Ordering System allows an employee to interact with a the Bangazon ordering database via a simple command line interface.

## Dependencies Required
1. SQLite

 ### For OSX Users

```
brew install sqlite
```

### For Windows Users

Visit the [SQLite downloads](https://www.sqlite.org/download.html) and download the 64-bit DLL (x64) for SQLite version, unzip and install it.

2. .NET Core

### For OSX Users:

Install .NET Core

https://www.microsoft.com/net/core#macos

Create and run an ASP.NET application using .NET Core

https://docs.asp.net/en/latest/getting-started.html


### For Windows Users

https://www.microsoft.com/net/core#windows


## Steps to install the code
 - Create an environment variable for your database file by adding the following statement to your .zshrc or .bashrc file (with your specific system path in place of the following example):

 ```
 export BANGAZONCLI_DB="/Users/KathleenWeisensel/workspace/csharp/bangazon/bangazoncli/bangazoncli.db"
 ```

 - Clone code onto your own local system:
 `git clone https://github.com/teamBangazon/BangazonCLI.git`

 - Then:
 `cd (name of created directory)`
 `cd bangazon`
 `dotnet restore`
 `dotnet run`



# Bangazon Command Line Interface for a Database

This program tracks customers, products, product types, orders, payments, and payment types for users of the Bangazon system.

*************************************************
Welcome to Bangazon! Command Line Ordering System
*************************************************
1. Create a customer account
2. Choose an active customer
3. Create a payment type
4. Add a product
5. Add a product to the shopping cart
6. Complete an order
7. Remove customer product
8. Update product information
9. Show stale products
10. Review revenue report for a customer
12. Leave Bangazon CLI

### Option 1. Create a customer account
Allows the user to create a new customer account.
User will be prompted to add required customer data.

### Option 2. Choose an active customer
Allows the user to select an active customer.
Displays a list of customers and prompts user to select number corresponding to active customer.

### Option 3. Create a payment type
Once an active customer has been selected, a payment type can be entered.

### Option 4. Add a product to sell
Once an active customer is chosen, the user can post a product for sale. User is prompted to add title, decrciption, and price of added product.

### Option 5. Add product to shopping cart
Checks for an open shopping cart for the active customer and creates one if needed. Available products are listed and the user can add these to the shopping cart.

### Option 6. Complete an order
After adding a product to the cart, this option lists payment types for the customer. The user can complete an order by choosing a desired payment type..

## The following options are not available in this version of Bangazon CLI (Version 1.0).

### Option 7. Remove customer product

### Option 8. Update product information

### Option 9. Show stale products

### Option 10. Get Revenue Report for customer

### Option 12.  Leave Bangazon!


## Contributors: Team Bangazon
- Kathy Weisensel
- Dylan Smith
- Willie Pruitt
- Peter Forrest
 