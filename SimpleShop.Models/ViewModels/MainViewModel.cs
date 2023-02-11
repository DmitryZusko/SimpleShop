using SimpleShop.Models.Services;

namespace SimpleShop.Models.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; set; }
        public MainViewModel(NavigationService navigationService) : base(navigationService)
        {
            NavigationService.CreateViewModel(CreateSellerListViewModel);
            CurrentViewModel = NavigationService.GetCurrentViewmodel();
            NavigationService.CurrentViewModelChanged += _navigationService_CurrentViewModelChanged;
        }

        private void _navigationService_CurrentViewModelChanged()
        {
            CurrentViewModel = NavigationService.GetCurrentViewmodel();
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
