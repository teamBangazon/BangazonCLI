using System;
using Bangazon.Models;
using Bangazon.StringBuilders;
using Xunit;

namespace Bangazon.Tests
{
    public class AddPaymentTypeStringBuilderManagerShould
    {
    private AddPaymentTypeStringBuilder kathy;
    public AddPaymentTypeStringBuilderManagerShould()
    {

    }
    [Fact]
    public void AddPaymentTypeReturnInt()
    {   
        PaymentType _paytype = new PaymentType("Visa", 01234958585);
        
        var X = kathy.AddPaymentType(_paytype);
        
        Assert.True(X != 0);  
        Console.WriteLine(X);   
    }
    }
}