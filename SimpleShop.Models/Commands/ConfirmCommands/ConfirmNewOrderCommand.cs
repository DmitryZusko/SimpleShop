using SimpleShop.Models.Models;
using SimpleShop.Models.Services.MVMServices.MVMCreators;
using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.ViewModels;
using SimpleShop.Models.ViewModels.ClassViewModels;
using SimpleShop.Models.ViewModels.SingleEntityViewModel;

namespace SimpleShop.Models.Commands.ConfirmCommands
{
    public class ConfirmNewOrderCommand : CommandBase
    {
        private NavigationService _navigationService;
        private OrderMVMCreator _orderCreator;
        private List<string> _orderInfo;
        private Func<ViewModelBase> _createOrderListViewModel;
        private SingleOrderViewModel _parentViewModel;

        public ConfirmNewOrderCommand(NavigationService navigationService, OrderMVMCreator orderCreator, List<string> orderInfo, Func<ViewModelBase> createOrderListViewModel, SingleOrderViewModel parentViewModel)
        {
            _navigationService = navigationService;
            _orderCreator = orderCreator; ;
            _orderInfo = orderInfo;
            _createOrderListViewModel = createOrderListViewModel;
            _parentViewModel = parentViewModel;
            _parentViewModel.PropertyChanged += _parentViewModel_PropertyChanged;
        }

        private void _parentViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            _orderInfo = new List<string>
            { 
                _parentViewModel.Amount.ToString("#.###"),
                _parentViewModel.SellerID.ToString(),
                _parentViewModel.CustomerID.ToString()
            };
        }

        public override void Execute(object? parameter)
        {
            _orderCreator.AddNew(new FullOrderViewModel
            {
                Amount = _orderInfo[0],
                OrderDate = DateTime.UtcNow.ToShortDateString(),
                SellerID = _orderInfo[1],
                CustomerID = _orderInfo[2]
            }); ;;
            _navigationService.CreateViewModel(_createOrderListViewModel);
        }
    }
}
