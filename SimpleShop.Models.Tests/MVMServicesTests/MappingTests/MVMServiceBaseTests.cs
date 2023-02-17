using NUnit.Framework;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.MVMServices;
using SimpleShop.Models.ViewModels.ClassViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Tests.MVMServicesTests.MappingTests
{
    [TestFixture]
    public class MVMServiceBaseTests
    {
        //I tested mapping with only one class, because it's a generic method and works in the same way with all types.
        //So, the main goal of this tests is to test Map<Ts,Td>() method, not automapper config.
        [Test]
        public void Map_ShoulMapSellerToSellerViewModel()
        {
            var seller = new Seller { ID = 1, FullName = "Test Name" };
            var service = new MVMServiceBase();

            var expected = new SellerViewModel { ID = seller.ID, FullName = seller.FullName };

            var actual = service.Map<Seller, SellerViewModel>(seller);

            Assert.IsTrue(actual is SellerViewModel);
            Assert.IsTrue(expected.ID == actual.ID && expected.FullName == actual.FullName);
        }

        [Test]
        public void Map_ShouldMapSellerViewModelToSeller()
        {
            var sellerVM = new SellerViewModel { ID = 1, FullName = "Test Name" };
            var service = new MVMServiceBase();

            var expected = new Seller { ID = sellerVM.ID, FullName = sellerVM.FullName };

            var actual = service.Map<SellerViewModel, Seller>(sellerVM);

            Assert.IsTrue(actual is Seller);
            Assert.IsTrue(actual.ID == expected.ID && actual.FullName == expected.FullName);
        }
    }
}
