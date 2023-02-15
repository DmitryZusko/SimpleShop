namespace SimpleShop.Models.Commands.DeleteCommands
{
    using SimpleShop.Models.Services.MVMServices.MVMRemovers;
    using SimpleShop.Models.Services.Navigation;
    using SimpleShop.Models.ViewModels.DeleteViewModels;
    using SimpleShop.Models.ViewModels.ListViewModels;
    /// <summary>
    /// Command that allows to delete Order
    /// </summary>
    public class DeleteOrderCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly OrderMVMRemover _orderRemover;
        private readonly Func<OrderListViewModel> _createNewView;
        private readonly OrderDeleteViewModel _parentViewModel;
        private int _id;

        public DeleteOrderCommand(NavigationService navigationService, OrderMVMRemover orderRemover, int iD, Func<OrderListViewModel> createNewView, OrderDeleteViewModel parentViewModel)
        {
            _navigationService = navigationService;
            _orderRemover = orderRemover;
            _id = iD;
            _createNewView = createNewView;
            _parentViewModel = parentViewModel;
            _parentViewModel.PropertyChanged += _parentViewModel_PropertyChanged;
        }

        private void _parentViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            _id = _parentViewModel.ID;
        }

        public override void Execute(object? parameter)
        {
            _orderRemover.Remove(_id);
            _navigationService.CreateViewModel(_createNewView);
        }
    }
}
