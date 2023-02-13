using SimpleShop.Models.ViewModels;

namespace SimpleShop.Models.Stores
{
    public class NavigationStore
    {
        public ViewModelBase PreviousViewModel { get; set; }

        private ViewModelBase _currentviewModel;
        public ViewModelBase CurrentViewModel
        {
            get { return _currentviewModel; }
            set
            {
                _currentviewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        public event Action CurrentViewModelChanged;

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
