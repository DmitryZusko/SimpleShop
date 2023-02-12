using SimpleShop.Models.Models;
using SimpleShop.Models.Services;
using SimpleShop.Models.ViewModels;
using SimpleShop.Models.ViewModels.SingleEntityViewModel;

namespace SimpleShop.Models.Commands.ConfirmCommands
{
    public class ConfirmNewSellerCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly SimpleShopEntity _simpleShop;
        private string _newSellerName;
        private readonly SingleSellerViewModel _viewModelSender;
        private readonly Func<ViewModelBase> _createSelerListViewModel;
        public ConfirmNewSellerCommand(NavigationService navigationService, SimpleShopEntity simpleShop, string fullName, Func<ViewModelBase> createSellerListViewModel, SingleSellerViewModel parentViewModel)
        {
            _navigationService = navigationService;
            _simpleShop = simpleShop;
            _newSellerName = fullName;
            _createSelerListViewModel = createSellerListViewModel;
            _viewModelSender = parentViewModel;
            parentViewModel.PropertyChanged += SingleSellerViewModel_PropertyChanged;
        }

        private void SingleSellerViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            _newSellerName = _viewModelSender.FullName;
        }

        public override void Execute(object? parameter)
        {
            _simpleShop.AddSeller(_newSellerName);
            _navigationService.CreateViewModel(_createSelerListViewModel);
        }
    }
}
