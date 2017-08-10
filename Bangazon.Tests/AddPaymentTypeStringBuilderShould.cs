using System;
using Bangazon.Models;
using Bangazon.StringBuilders;
using Xunit;

namespace Bangazon.Tests
{
    public class AddPaymentTypeStringBuilderManagerShould
    {
    private readonly DatabaseInterface _db;
    private AddPaymentTypeStringBuilder _kathy;
    public AddPaymentTypeStringBuilderManagerShould()
    {
        _db = new DatabaseInterface("BANGAZONCLI_DB");
        _db.CheckPaymentTypeTable();
        _kathy = new AddPaymentTypeStringBuilder(_db);
    }
    [Fact]
    public void AddPaymentTypeReturnInt()
    {   
        PaymentType _paytype = new PaymentType("Visa", 01234958585);
        
        var X = _kathy.AddPaymentType(_paytype);
        
        Assert.True(X != 0);     
    }
    }
}