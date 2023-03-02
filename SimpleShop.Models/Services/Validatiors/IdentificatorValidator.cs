namespace SimpleShop.Models.Services.Validatiors
{
    using SimpleShop.Models.Models;
    /// <summary>
    /// Allows to find out if entity with specific id contains in the DataBase or not.
    /// </summary>
    public partial class IdentificatorValidator
    {
        private readonly ISimpleShopEntity _simpleShop;
        public IdentificatorValidator(ISimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
        }
        public bool Validate(int id, ValidationMode mode)
        {
            switch (mode)
            {
                case ValidationMode.seller:
                    {
                        return _simpleShop.GetSellerCount(id) == 1;
                    }
                case ValidationMode.customer:
                    {
                        return _simpleShop.GetCustomerCount(id) == 1;
                    }
                case ValidationMode.order:
                    {
                        return _simpleShop.GetOrderCount(id) == 1;
                    }
                default:
                    return false;
            }
        }
    }
}
