namespace SimpleShop.Models.Commands.ConfirmCommands
{
    using SimpleShop.Models.Services.MVMServices.MVMCreators;
    using SimpleShop.Models.Services.Navigation;
    using SimpleShop.Models.ViewModels;
    using SimpleShop.Models.ViewModels.SingleEntityViewModel;
    /// <summary>
    /// Command that allows to add new Order
    /// </summary>
    public class ConfirmNewOrderCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly OrderMVMCreator _orderCreator;
        private readonly Func<ViewModelBase> _createOrderListViewModel;
        private readonly SingleOrderViewModel _parentViewModel;
        private List<string> _orderInfo;

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
            _orderCreator.AddNew(_orderInfo);
            _navigationService.CreateViewModel(_createOrderListViewModel);
        }
    }
}
