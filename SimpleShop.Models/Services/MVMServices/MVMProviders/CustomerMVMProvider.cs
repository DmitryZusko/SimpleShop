namespace SimpleShop.Models.Services.MVMServices.MVMProviders
{
    using SimpleShop.Models.Models;
    using SimpleShop.Models.ViewModels.ClassViewModels;
    using System.Collections.ObjectModel;
    /// <summary>
    /// Loads customers from Model to ViewModel.
    /// </summary>
    public class CustomerMVMProvider : MVMServiceBase
    {
        private readonly ISimpleShopEntity _simpleShop;

        public CustomerMVMProvider(ISimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
        }

        public ObservableCollection<CustomerViewModel> GetCustomers()
        {
            return new ObservableCollection<CustomerViewModel>(_simpleShop.GetCustomersList().Select(c => Map<Customer, CustomerViewModel>(c)));
        }
    }
}
