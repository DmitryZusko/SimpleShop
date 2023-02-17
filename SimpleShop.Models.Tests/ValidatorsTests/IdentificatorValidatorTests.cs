namespace SimpleShop.Models.Tests.ValidatorsTests
{
    using Autofac.Extras.Moq;
    using NUnit.Framework;
    using SimpleShop.Models.Models;
    using SimpleShop.Models.Services.Validatiors;

    [TestFixture]
    public class IdentificatorValidatorTests
    {
        [Test]
        [TestCase(1, true)]
        [TestCase(2, false)]
        public void Validator_SellerShouldBeValidated(int id, bool expected)
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<SimpleShopEntity>()
                    .Setup(x => x.GetSellerCount(id))
                    .Returns(ValidatorsResult(id));

                var validator = mock.Create<IdentificatorValidator>();

                var actual = validator.Validate(id, IdentificatorValidator.ValidationMode.seller);

                Assert.AreEqual(expected, actual);
            }
        }

        [Test]
        [TestCase(1, true)]
        [TestCase(2, false)]
        public void Validator_CustomerShouldBeValidated(int id, bool expected)
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<SimpleShopEntity>()
                    .Setup(x => x.GetCustomerCount(id))
                    .Returns(ValidatorsResult(id));

                var validator = mock.Create<IdentificatorValidator>();

                var actual = validator.Validate(id, IdentificatorValidator.ValidationMode.customer);

                Assert.AreEqual(expected, actual);
            }
        }

        [Test]
        [TestCase(1, true)]
        [TestCase(2, false)]
        public void Validator_OrderShouldBeValidated(int id, bool expected)
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<SimpleShopEntity>()
                    .Setup(x => x.GetOrderCount(id))
                    .Returns(ValidatorsResult(id));

                var validator = mock.Create<IdentificatorValidator>();

                var actual = validator.Validate(id, IdentificatorValidator.ValidationMode.order);

                Assert.AreEqual(expected, actual);
            }
        }


        private int ValidatorsResult(int id)
        {
            switch (id)
            {
                case 1:
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
