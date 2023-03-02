using Autofac.Extras.Moq;
using Moq;
using NUnit.Framework;
using SimpleShop.Models.Models;

namespace SimpleShop.Models.Tests.MVMServicesTests
{
    [TestFixture]
    internal class SimpleShopEntityTests
    {
        [Test]
        public void GetSellersList_ShouldReturnSellerList()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IGeneralLedger>()
                    .Setup(x => x.GetSellersList())
                    .Returns(GetSampleSellerList());

                var simpleShop = mock.Create<SimpleShopEntity>();

                var expected = GetSampleSellerList();

                var actual = simpleShop.GetSellersList();

                Assert.AreEqual(expected.Count(), actual.Count());
            }
        }

        [Test]
        public void AddSeller_ShouldAddNewSeller()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var newSeller = new Seller { ID = 1, FullName = "Test Seller" };
                mock.Mock<IGeneralLedger>()
                    .Setup(x => x.AddSeller(newSeller));

                var simpleShop = mock.Create<SimpleShopEntity>();

                simpleShop.AddSeller(newSeller);

                mock.Mock<IGeneralLedger>()
                    .Verify(x => x.AddSeller(newSeller), Times.Once);
            }
        }

        [Test]
        public void DeleteSeller_ShouldDeleteSeller()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var idForDelete = 1;

                mock.Mock<IGeneralLedger>()
                    .Setup(x => x.DeleteSeller(idForDelete));

                var simpleShop = mock.Create<SimpleShopEntity>();

                simpleShop.DeleteSeller(idForDelete);

                mock.Mock<IGeneralLedger>()
                    .Verify(x => x.DeleteSeller(idForDelete), Times.Once);
            }
        }

        private List<Seller> GetSampleSellerList()
        {
            return new List<Seller>
            {
                new Seller {ID = 1, FullName = "Test Seller 1"},
                new Seller {ID = 2, FullName = "Test Seller 2"}
            };
        }
    }
}
