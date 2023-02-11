using SimpleShop.Models.Services;
using SimpleShop.Models.ViewModels;
using System.Windows;

namespace SimpleShop.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ViewModelBase _mainViewModel;
        private readonly NavigationService _navigationService;
        public App()
        {
            _navigationService = new NavigationService();
            _mainViewModel = new MainViewModel(_navigationService);
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow
            {
                DataContext = _mainViewModel
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
