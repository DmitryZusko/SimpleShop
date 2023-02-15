namespace SimpleShop.Models.Services.Validatiors
{
    using SimpleShop.Models.Models;
    /// <summary>
    /// Allows to find out if entity with specific id contains in the DataBase or not.
    /// </summary>
    public partial class IdentificatorValidator
    {
        private readonly SimpleShopEntity _simpleShop;
        public IdentificatorValidator(SimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
        }
        public bool Validate(int id, ValidationMode mode)
        {
            switch (mode)
            {
                case ValidationMode.seller:
                    {
                        return _simpleShop.GetSellersList().Where(s => s.ID == id).Count() == 1;
                    }
                case ValidationMode.customer:
                    {
                        return _simpleShop.GetCustomersList().Where(c => c.ID == id).Count() == 1;
                    }
                case ValidationMode.order:
                    {
                        return _simpleShop.GetOrdersList().Where(o => o.ID == id).Count() == 1;
                    }
                default:
                    return false;
            }
        }
    }
}
