// Class: PaymentType
// Purpose: This class stores payment methods and account numbers
// Author: Team One to What - Kathy Weisensel
// Properties:
//  PaymentMethod: The customer's method of payment
//  AccountNumber: The customer's account number

namespace Bangazon.Models
{
    public class PaymentType
    {
        public string PaymentMethod { get; set; }
        public string AccountNumber { get; set; }

         public PaymentType(string customerPaymentMethod, string customerAccountNumber)
         {
            PaymentMethod = customerPaymentMethod;
            AccountNumber = customerAccountNumber;
         }
         public PaymentType () 
         {

         }
    }
}