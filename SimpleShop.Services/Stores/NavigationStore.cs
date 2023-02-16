namespace SimpleShop.Models.Stores
{
    using SimpleShop.Models.ViewModels;
    public class NavigationStore
    { 
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
        /// <summary>
        /// Invoking this event allows to change active view on MainView.
        /// </summary>
        public event Action CurrentViewModelChanged;

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
