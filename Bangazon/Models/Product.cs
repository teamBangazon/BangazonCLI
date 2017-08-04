//Class: Product
//Purpose: Create product for a customer
//Author: Team One to What
//Properties:
//  CustomerId: Identifies specific active customer
//  Name: name of product
//  Description: description of product details
//  Price: cost of product
//  ProductType: type of product


namespace Bangazon.Models
{
    public class Product
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ProductType { get; set; }
 
         public Product(int customerId, string productName, string productDescription, double productPrice, string productType)
         {
            CustomerId = customerId;
            Name =  productName;
            Description = productDescription;
            Price = productPrice;
            ProductType = productType;
         }
    }

   



}