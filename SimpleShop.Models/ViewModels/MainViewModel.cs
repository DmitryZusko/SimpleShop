using SimpleShop.Models.Models;
using SimpleShop.Models.Services;

namespace SimpleShop.Models.ViewModels
{
    public class MainViewModel : ViewModelCommandsBase
    {
        public ViewModelBase CurrentViewModel { get; set; }
        public MainViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _navigationService.CreateViewModel(CreateSellerListViewModel);
            CurrentViewModel = _navigationService.GetCurrentViewmodel();
            _navigationService.CurrentViewModelChanged += _navigationService_CurrentViewModelChanged;
        }

        private void _navigationService_CurrentViewModelChanged()
        {
            CurrentViewModel = _navigationService.GetCurrentViewmodel();
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
