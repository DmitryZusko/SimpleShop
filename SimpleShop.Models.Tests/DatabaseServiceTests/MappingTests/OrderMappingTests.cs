namespace SimpleShop.Models.Tests.DatabaseServiceTests.MappingTests
{
    using NUnit.Framework;
    using SimpleShop.DataBaseModel.DTOs;
    using SimpleShop.Models.Models;
    using SimpleShop.Models.Services.DatabaseServices.DatabaseCreators;

    [TestFixture]
    public class OrderMappingTests
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
                CustomerId = 1,
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
        }

        [Test]
        public void Map_ShouldMapOrderIdToOrderDTOId()
        {
            var orderCreator = new OrderDatabaseCreator();
            var order = new Order
            {
                ID = 1,
                OrderDate = "Feb 12 2023 5:31PM",
                Amount = 10.10m,
                SellerId = 1,
                CustomerId = 1,
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

            Assert.AreEqual(expected.ID, actual.ID);
        }

        [Test]
        public void Map_ShouldMapOrderDateToOrderDTODate()
        {
            var orderCreator = new OrderDatabaseCreator();
            var order = new Order
            {
                ID = 1,
                OrderDate = "Feb 12 2023 5:31PM",
                Amount = 10.10m,
                SellerId = 1,
                CustomerId = 1,
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

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }

        [Test]
        public void Map_ShouldMapOrderAmountToOrderDTOAmount()
        {
            var orderCreator = new OrderDatabaseCreator();
            var order = new Order
            {
                ID = 1,
                OrderDate = "Feb 12 2023 5:31PM",
                Amount = 10.10m,
                SellerId = 1,
                CustomerId = 1,
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

            Assert.AreEqual(expected.Amount, actual.Amount);
        }

        [Test]
        public void Map_ShouldMapOrderSellerIdToOrderDTOSellerId()
        {
            var orderCreator = new OrderDatabaseCreator();
            var order = new Order
            {
                ID = 1,
                OrderDate = "Feb 12 2023 5:31PM",
                Amount = 10.10m,
                SellerId = 1,
                CustomerId = 1,
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

            Assert.AreEqual(expected.SellerID, actual.SellerID);
        }

        [Test]
        public void Map_ShouldMapOrderCustomerIdToOrderDTOCustomerId()
        {
            var orderCreator = new OrderDatabaseCreator();
            var order = new Order
            {
                ID = 1,
                OrderDate = "Feb 12 2023 5:31PM",
                Amount = 10.10m,
                SellerId = 1,
                CustomerId = 1,
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

            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
        }
    }
}
