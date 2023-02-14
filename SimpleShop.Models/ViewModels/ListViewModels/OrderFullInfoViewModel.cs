using SimpleShop.Models.Commands.ShowCommands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.MVMServices.MVMProviders;
using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.ViewModels.ClassViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.ListViewModels
{
    public class OrderFullInfoViewModel : ViewModelCommandsBase
    {
        private readonly OrderMVMProvider _orderProvider;

        public ObservableCollection<FullOrderViewModel> Orders { get; set; }
        public ICommand CancelCommand { get; }
        public OrderFullInfoViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _orderProvider = new OrderMVMProvider(_simpleShop);

            CancelCommand = new ShowOrdersCommand(navigationService, CreateOrderListViewModel);

            Orders = _orderProvider.GetFullOrders();
        }
    }
}
