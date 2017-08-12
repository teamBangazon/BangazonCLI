using Bangazon.Managers;
using Bangazon.Models;
using Xunit;


namespace Bangazon.Tests
{
    public class AddOrderManagerShould
    {
        // private OrderManager _newOrderManager;
        public void AddOrderManagerShouldDo()
        {
            
        }

        [Fact]
        public void AddProductToOrderShould()
        {
            Product _newProduct = new Product(1, "Testing", "This is a test", 1234, "still a test");
            var result = OrderManager.AddProductToOrder(_newProduct);
            Assert.Equal(result, 3);
        }

        [Fact]
        public void DoesOrderExistShould()
        {
            var result = OrderManager.DoesOrderExist(1);
            Assert.IsType<bool>(result);
        }
    }
}