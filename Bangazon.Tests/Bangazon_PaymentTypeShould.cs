using System;
using Xunit;
using Bangazon.Models;

namespace Bangazon.Tests
{
    public class PaymentTypeShould
    {
        private PaymentType _paymentType;

        public PaymentTypeShould()
        {
            _paymentType = new PaymentType("Visa", "5555-3424-8999-1111");
        }

        [Fact]
        public void addPaymentType()
        {
            Assert.Equal(_paymentType.PaymentMethod, "Visa");
            Assert.Equal(_paymentType.AccountNumber, "5555-3424-8999-1111");
        }
    }
}