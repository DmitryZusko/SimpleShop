using SimpleShop.Models.Commands;
using SimpleShop.Models.Commands.ShowCommands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.ModelViewModelConverter;
using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.ViewModels.ClassViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.ListViewModels
{
    public class OrderFullInfoViewModel : ViewModelCommandsBase
    {
        public ObservableCollection<FullOrderViewModel> Orders { get; set; }
        public ICommand CancelCommand { get; }
        private readonly MVVMConverter _mvmConverter;
        public OrderFullInfoViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            CancelCommand = new ShowOrdersCommand(navigationService, CreateOrderListViewModel);
            _mvmConverter = new MVVMConverter();

            Orders = _mvmConverter.FromModelToVM<Order, FullOrderViewModel>(_simpleShop.GetOrdersList());
        }
    }
}
