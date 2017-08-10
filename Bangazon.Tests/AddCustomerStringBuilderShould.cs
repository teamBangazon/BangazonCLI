using System;
using Bangazon.Models;
using Bangazon.StringBuilders;
using Xunit;

namespace Bangazon.Tests
{
    public class AddCustomerStringBuilderManagerShould
    {
    private readonly DatabaseInterface _db;

    private AddCustomerStringBuilder _Dylan;

    public AddCustomerStringBuilderManagerShould()
    {
        _db = new DatabaseInterface("BANGAZONCLI_DB");
        _db.CheckCustomerTable();
        _Dylan = new AddCustomerStringBuilder(_db);
    }
    
    [Fact]
    public void AddCustomerReturnInt()
    {   
        Customer _custy = new Customer("Dylan", "Smith", "WarriorDr", "Murfreesboro", "TN", 37128, "615-481-2667");
        
        var X = _Dylan.AddCustomer(_custy);
        
        Assert.True(X != 0);  
        Console.WriteLine(X);   
    }

    }
}