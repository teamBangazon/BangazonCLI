using System.Collections.Generic;

//Class: Order
//Purpose: Used to store Customer's Order
//Author: Team One to What
//Properties:
//  CustomerId: CustomerId of customer purchasing Order
//  PaymentTypeId: PaymentTypeId(will need to be nullable when fully implemented)
//  ProductIdList: List to hold ProductIds(will need to be ICollection based on FK assignments)

namespace Bangazon.Models

{
    public class Order
    {
        public int id { get; set; }
        public int CustomerId { get; set; }
        public int PaymentTypeId { get; set; }

        public Order(int customerId, int paymentTypeId)
        {
            CustomerId = customerId;
            PaymentTypeId = paymentTypeId; 
        }

        public Order()
        {
            
        }

    }

}