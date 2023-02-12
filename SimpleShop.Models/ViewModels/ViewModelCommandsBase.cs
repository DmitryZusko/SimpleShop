using SimpleShop.Models.Models;
using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.ViewModels.ClassViewModels;
using SimpleShop.Models.ViewModels.DeleteViewModels;
using SimpleShop.Models.ViewModels.ListViewModels;
using SimpleShop.Models.ViewModels.SingleEntityViewModel;

namespace SimpleShop.Models.ViewModels
{
    public abstract class ViewModelCommandsBase : ViewModelBase
    {
        protected SimpleShopEntity _simpleShop;
        protected NavigationService _navigationService;
        protected ViewModelCommandsBase(NavigationService navigationService, SimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
            _navigationService = navigationService;
        }

        public SellerListViewModel CreateSellerListViewModel()
        {
            return new SellerListViewModel(_navigationService, _simpleShop);
        }

        public CustomerListViewModel CreateCustomerListViewModel()
        {
            return new CustomerListViewModel(_navigationService, _simpleShop);
        }

        public OrderListViewModel CreateOrderListViewModel()
        {
            return new OrderListViewModel(_navigationService, _simpleShop);
        }

        public OrderFullInfoViewModel CreateFullOrderInfoViewModel()
        {
            return new OrderFullInfoViewModel(_navigationService, _simpleShop);
        }

        public SingleSellerViewModel CreateSingleSellerViewModel()
        {
            return new SingleSellerViewModel(_navigationService, _simpleShop);
        }

        public SingleCustomerViewModel CreateSingleCustomerViewModel()
        {
            return new SingleCustomerViewModel(_navigationService, _simpleShop);
        }

        public SingleOrderViewModel CreateSingleOrderViewModel()
        {
            return new SingleOrderViewModel(_navigationService, _simpleShop);
        }

        public SellerDeleteViewModel CreateSellerDeleteViewModel()
        {
            return new SellerDeleteViewModel(_navigationService, _simpleShop);
        }

        public CustomerDeleteViewModel CreateCustomerDeleteViewModel()
        {
            return new CustomerDeleteViewModel(_navigationService, _simpleShop);
        }

        public OrderDeleteViewModel CreateOrderDeleteViewModel()
        {
            return new OrderDeleteViewModel(_navigationService, _simpleShop);
        }
    }
}
