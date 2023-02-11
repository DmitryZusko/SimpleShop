using SimpleShop.Models.Models;
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
        public SimpleShopEntity SimpleShop { get; set; }
        public App()
        {
            SimpleShop = new SimpleShopEntity();
            _navigationService = new NavigationService();
            _mainViewModel = new MainViewModel(_navigationService, SimpleShop);
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            SimpleShop = new SimpleShopEntity();
            MainWindow = new MainWindow
            {
                DataContext = _mainViewModel
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
