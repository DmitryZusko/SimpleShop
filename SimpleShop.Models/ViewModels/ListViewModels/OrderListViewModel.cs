using SimpleShop.Models.Commands.AddNewCommands;
using SimpleShop.Models.Commands.DeleteCommands;
using SimpleShop.Models.Commands.ShowCommands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.MVMServices.MVMProviders;
using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.ViewModels.ClassViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.ListViewModels
{
    public class OrderListViewModel : ViewModelCommandsBase
    {
        private readonly OrderMVMProvider _orderProvider;

        public ObservableCollection<OrderViewModel> Orders { get; set; }
        public ICommand ShowSellersCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowOrdersCommand { get; }
        public ICommand ShowOrderFullInfoCommand { get; }
        public ICommand AddNewOrderCommand { get; }
        public ICommand DeleteOrderCommand { get; }

        public OrderListViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _orderProvider = new OrderMVMProvider(_simpleShop);

            ShowSellersCommand = new ShowSellersCommand(_navigationService, CreateSellerListViewModel);
            ShowCustomersCommand = new ShowCustomersCommand(_navigationService, CreateCustomerListViewModel);
            ShowOrdersCommand = new ShowOrdersCommand(_navigationService, CreateOrderListViewModel);
            ShowOrderFullInfoCommand = new ShowOrderFullInfoCommand(_navigationService, CreateFullOrderInfoViewModel);
            AddNewOrderCommand = new AddNewOrderCommand(_navigationService, CreateSingleOrderViewModel);
            DeleteOrderCommand = new OpenCustomerDeleteMenuCommand(_navigationService, CreateOrderDeleteViewModel);

            Orders = _orderProvider.GetOrders();
        }

        public override bool NavigationStoreShouldStore()
        {
            return true;
        }
    }
}
