using NUnit.Framework;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.DatabaseServices.DatabaseCreators;

namespace SimpleShop.Models.Tests.DatabaseServiceTests.MappingTests
{
    [TestFixture]
    public class SellerMappingTests
    {
        [Test]
        public void Map_ShouldMapSellerToSellerDTO()
        {
            var seller = new Seller { ID = 1, FullName = "Test Name" };
            var sellerCreator = new SellerDatabaseCreator();

            var expected = new SellerDTO { ID = seller.ID, FullName = seller.FullName };

            var actual = sellerCreator.Map<Seller, SellerDTO>(seller);

            Assert.IsTrue(actual is SellerDTO);
            Assert.IsTrue(expected.ID == actual.ID && expected.FullName == actual.FullName);
        }
    }
}
