using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;
using System.Windows;

namespace SimpleShop.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        private readonly ViewModelBase _mainViewModel;
        public App()
        {
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new SellerListViewModel(_navigationStore);
            MainWindow = new MainWindow
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
