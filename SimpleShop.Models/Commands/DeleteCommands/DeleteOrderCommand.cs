using SimpleShop.Models.Models;
using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.ViewModels.DeleteViewModels;
using SimpleShop.Models.ViewModels.ListViewModels;

namespace SimpleShop.Models.Commands.DeleteCommands
{
    public class DeleteOrderCommand : CommandBase
    {
        private NavigationService _navigationService;
        private SimpleShopEntity _simpleShop;
        private int _id;
        private Func<OrderListViewModel> _createNewView;
        private OrderDeleteViewModel _parentViewModel;

        public DeleteOrderCommand(NavigationService navigationService, SimpleShopEntity simpleShop, int iD, Func<OrderListViewModel> createNewView, OrderDeleteViewModel parentViewModel)
        {
            _navigationService = navigationService;
            _simpleShop = simpleShop;
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
            _simpleShop.DeleteOrder(_id);
            _navigationService.CreateViewModel(_createNewView);
        }
    }
}
