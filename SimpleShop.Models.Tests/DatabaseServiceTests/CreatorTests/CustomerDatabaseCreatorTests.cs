﻿namespace SimpleShop.Models.Tests.DatabaseServiceTests.CreatorTests
{
    using NUnit.Framework;
    using SimpleShop.DataBaseModel.DTOs;
    using SimpleShop.Models.Models;
    using SimpleShop.Models.Services.DatabaseServices.DatabaseCreators;

    [TestFixture]
    public class CustomerDatabaseCreatorTests
    {
        [Test]
        public void Map_ShouldMapCustomerToCustomerDTO()
        {
            var customerCreator = new CustomerDatabaseCreator();
            var customer = new Customer { ID = 1, Company = "Test Company" };

            var expected = new CustomerDTO { ID = customer.ID, Company = customer.Company };

            var actual = customerCreator.Map<Customer, CustomerDTO>(customer);

            Assert.IsTrue(actual is CustomerDTO);
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Company, actual.Company);
        }
    }
}
