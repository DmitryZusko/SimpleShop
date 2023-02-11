using SimpleShop.Models.Commands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services;
using SimpleShop.Models.Stores;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels
{
    public class OrderListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<OrderViewModel> _orders;
        public ObservableCollection<OrderViewModel> Orders => _orders;
        public ICommand ShowSellersCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowOrdersCommand { get; }
        public ICommand ShowOrderFullInfoCommand { get; }
        public ICommand AddNewOrderCommand { get; }
        public ICommand UpdateOrderCommand { get; }
        public ICommand DeleteOrderCommand { get; }
        public OrderListViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            NavigationService = navigationService;
            ShowSellersCommand = new ShowSellersCommand(NavigationService, CreateSellerListViewModel);
            ShowCustomersCommand = new ShowCustomersCommand(NavigationService, CreateCustomerListViewModel);
            ShowOrdersCommand = new ShowOrdersCommand(NavigationService, CreateOrderListViewModel);
            //ShowOrderFullInfoCommand = new ShowOrderFullInfoCommand(_navigationService);
            AddNewOrderCommand = new AddNewOrderCommand(NavigationService, CreateOrderViewModel);
            UpdateOrderCommand = new UpdateOrderCommand(NavigationService, CreateOrderViewModel);
            //DeleteOrderCommand = new DeleteOrderCommand(_navigationService);
        }

        public override bool NavigationStoreShouldStore()
        {
            return true;
        }
    }
}
