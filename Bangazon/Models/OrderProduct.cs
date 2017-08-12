using System.Collections.Generic;

//Class: OrderProduct
//Purpose: Used to store individual products that have been added to orders i.e. Invoice line item
//Author: Team One to What
//Properties:
//  CustomerId: CustomerId of customer purchasing Order
//  PaymentTypeId: PaymentTypeId(will need to be nullable when fully implemented)
//  ProductIdList: List to hold ProductIds(will need to be ICollection based on FK assignments)

namespace Bangazon.Models

{
    public class OrderProduct
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public OrderProduct(int customerId, int productId)
        {
            OrderId = customerId; 
            ProductId = productId; 
        }
    }
    
}