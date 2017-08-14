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
            var result = OrderManager.AddProductToOrder(1, 1);
            Assert.IsType<int>(result);
        }

        [Fact]
        public void GetCurrentOrderShould()
        {   
            var result = OrderManager.GetCurrentOrder(1);
            Assert.NotEqual(null, result);
        }
    }
}