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
        public int CustomerId { get; set; }
        public int PaymentTypeId { get; set; }
        public List<int> ProductIdList { get; } = new List<int>();

        public Order(int customerId)
        {
            CustomerId = customerId;  
        }


    }

}