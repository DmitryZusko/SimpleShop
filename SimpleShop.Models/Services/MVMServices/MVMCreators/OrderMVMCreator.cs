namespace SimpleShop.Models.Services.MVMServices.MVMCreators
{
    using SimpleShop.Models.Models;
    using SimpleShop.Models.Services.Validatiors;
    using SimpleShop.Models.ViewModels.ClassViewModels;
    /// <summary>
    /// Hangs over adding new order operation from ViewModel to Model.
    /// </summary>
    public class OrderMVMCreator : MVMServiceBase
    {
        private readonly ISimpleShopEntity _simpleShop;
        private readonly IdentificatorValidator _idValidator;

        public OrderMVMCreator(ISimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
            _idValidator = new IdentificatorValidator(_simpleShop);
        }

        public void AddNew(List<string> orderInfo)
        {
            int sellerId;
            int customerId;
            int.TryParse(orderInfo[1], out sellerId);
            int.TryParse(orderInfo[2], out customerId);
            if (_idValidator.Validate(sellerId, IdentificatorValidator.ValidationMode.seller) && _idValidator.Validate(customerId, IdentificatorValidator.ValidationMode.customer))
            {
                var newOrder = new FullOrderViewModel
                {
                    Amount = orderInfo[0],
                    OrderDate = DateTime.UtcNow.ToShortDateString(),
                    SellerID = orderInfo[1],
                    CustomerID = orderInfo[2]
                };
                _simpleShop.AddOrder(Map<FullOrderViewModel, Order>(newOrder));
            }
        }
    }
}
