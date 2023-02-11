using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;

namespace SimpleShop.Models.Services
{
    public class NavigationService
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<ViewModelBase> _createViewModel;
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
            if (_navigationStore.CurrentViewModel?.NavigationStoreShouldStore() == false)
            {
                _navigationStore.CurrentViewModel = newViewModel();
            }
            _navigationStore.PreviousViewModel = _navigationStore.CurrentViewModel;
            _navigationStore.CurrentViewModel = newViewModel();
        }

        public void ReturnToPreviousViewModel()
        {
            if (_navigationStore.PreviousViewModel == null)
            {
                return;
            }
            _navigationStore.CurrentViewModel = _navigationStore.PreviousViewModel;
        }

    }
}
