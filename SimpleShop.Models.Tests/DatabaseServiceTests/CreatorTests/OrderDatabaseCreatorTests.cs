namespace SimpleShop.Models.Tests.DatabaseServiceTests.CreatorTests
{
    using NUnit.Framework;
    using SimpleShop.DataBaseModel.DTOs;
    using SimpleShop.Models.Models;
    using SimpleShop.Models.Services.DatabaseServices.DatabaseCreators;

    [TestFixture]
    public class OrderDatabaseCreatorTests
    {
        [Test]
        public void Map_ShouldMapOrderToOrderDTO() 
        {
            var orderCreator = new OrderDatabaseCreator();
            var order = new Order
            {
                ID = 1,
                OrderDate = "Feb 12 2023 5:31PM",
                Amount = 10.10m,
                SellerId = 1,
                SellerFullName = "Test Seller",
                CustomerId = 1,
                CustomerCompany = "Test Customer"
            };

            var expected = new OrderDTO
            {
                ID = order.ID,
                OrderDate = DateTime.Parse(order.OrderDate),
                Amount = order.Amount,
                SellerID = order.SellerId,
                CustomerID = order.CustomerId,
            };

            var actual = orderCreator.Map<Order, OrderDTO>(order);

            Assert.IsTrue(expected is OrderDTO);
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
            Assert.AreEqual(expected.Amount, actual.Amount);
            Assert.AreEqual(expected.SellerID, actual.SellerID);
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);


        }
    }
}
