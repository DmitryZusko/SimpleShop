using SimpleShop.Models.Models;
using SimpleShop.Models.Services;
using SimpleShop.Models.ViewModels;
using SimpleShop.Models.ViewModels.SingleEntityViewModel;

namespace SimpleShop.Models.Commands.ConfirmCommands
{
    public class ConfirmNewOrderCommand : CommandBase
    {
        private NavigationService _navigationService;
        private SimpleShopEntity _simpleShop;
        private List<string> _orderInfo;
        private Func<ViewModelBase> _createOrderListViewModel;
        private SingleOrderViewModel _parentViewModel;

        public ConfirmNewOrderCommand(NavigationService navigationService, SimpleShopEntity simpleShop, List<string> orderInfo, Func<ViewModelBase> createOrderListViewModel, SingleOrderViewModel parentViewModel)
        {
            _navigationService = navigationService;
            _simpleShop = simpleShop; ;
            _orderInfo = orderInfo;
            _createOrderListViewModel = createOrderListViewModel;
            _parentViewModel = parentViewModel;
            _parentViewModel.PropertyChanged += _parentViewModel_PropertyChanged;
        }

        private void _parentViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            _orderInfo = new List<string>
            { 
                _parentViewModel.Amount.ToString(),
                _parentViewModel.SellerID.ToString(),
                _parentViewModel.CustomerID.ToString()
            };
        }

        public override void Execute(object? parameter)
        {
            _simpleShop.AddOrder(_orderInfo);
            _navigationService.CreateViewModel(_createOrderListViewModel);
        }
    }
}
