namespace SimpleShop.Models.Services.Navigation
{
    using SimpleShop.Models.Stores;
    using SimpleShop.Models.ViewModels;
    using SimpleShop.Models.ViewModels.ListViewModels;
    /// <summary>
    /// This service responsible for creating new ViewModels and switching between them.
    /// </summary>
    public class NavigationService
    {
        private readonly NavigationStore _navigationStore;
        public NavigationService()
        {
            _navigationStore = new NavigationStore();
            _navigationStore.CurrentViewModelChanged += _navigationStore_CurrentViewModelChanged;
        }

        public event Action CurrentViewModelChanged;

        private void _navigationStore_CurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
        public ViewModelBase GetCurrentViewmodel()
        {
            return _navigationStore.CurrentViewModel;
        }

        public void CreateViewModel(Func<ViewModelBase> newViewModel)
        {
            _navigationStore.CurrentViewModel = newViewModel();
        }
    }
}
