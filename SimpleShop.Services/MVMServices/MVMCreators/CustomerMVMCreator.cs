namespace SimpleShop.Models.Services.MVMServices.MVMCreators
{
    using SimpleShop.Models.Models;
    using SimpleShop.Models.ViewModels.ClassViewModels;
    /// <summary>
    /// Hangs over adding new customer operation from ViewModel to Model.
    /// </summary>
    public class CustomerMVMCreator : MVMServiceBase
    {
        private readonly SimpleShopEntity _simpleShop;

        public CustomerMVMCreator(SimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
        }

        public void AddNew(CustomerViewModel newCustomer)
        {
            _simpleShop.AddCustomer(Map<CustomerViewModel, Customer>(newCustomer));
        }
    }
}
