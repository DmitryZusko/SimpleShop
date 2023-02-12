using SimpleShop.Models.Commands;
using SimpleShop.Models.Commands.AddNewCommands;
using SimpleShop.Models.Commands.DeleteCommands;
using SimpleShop.Models.Commands.ShowCommands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.ModelViewModelConverter;
using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels.ClassViewModels;
using SimpleShop.Models.ViewModels.SingleEntityViewModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.ListViewModels
{
    public class OrderListViewModel : ViewModelCommandsBase
    {
        public ObservableCollection<OrderViewModel> Orders { get; set; }
        public ICommand ShowSellersCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowOrdersCommand { get; }
        public ICommand ShowOrderFullInfoCommand { get; }
        public ICommand AddNewOrderCommand { get; }
        public ICommand DeleteOrderCommand { get; }

        private readonly MVVMConverter _mvmConverter;
        public OrderListViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _mvmConverter = new MVVMConverter();

            Orders = _mvmConverter.FromModelToVM<Order, OrderViewModel>(_simpleShop.GetOrdersList());

            ShowSellersCommand = new ShowSellersCommand(_navigationService, CreateSellerListViewModel);
            ShowCustomersCommand = new ShowCustomersCommand(_navigationService, CreateCustomerListViewModel);
            ShowOrdersCommand = new ShowOrdersCommand(_navigationService, CreateOrderListViewModel);
            ShowOrderFullInfoCommand = new ShowOrderFullInfoCommand(_navigationService, CreateFullOrderInfoViewModel);
            AddNewOrderCommand = new AddNewOrderCommand(_navigationService, CreateSingleOrderViewModel);
            DeleteOrderCommand = new OpenCustomerDeleteMenuCommand(_navigationService, CreateOrderDeleteViewModel);
        }

        public override bool NavigationStoreShouldStore()
        {
            return true;
        }
    }
}
