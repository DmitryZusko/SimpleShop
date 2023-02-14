using SimpleShop.Models.Commands.AddNewCommands;
using SimpleShop.Models.Commands.DeleteCommands;
using SimpleShop.Models.Commands.ShowCommands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.MVMServices.MVMProviders;
using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.ViewModels.ClassViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.ListViewModels
{
    public class SellerListViewModel : ViewModelCommandsBase
    {
        private readonly SellerMVMProvider _sellerProvider;

        public ObservableCollection<SellerViewModel> Sellers { get; set; }
        public SellerViewModel BindedSeller { get; set; }
        public ICommand ShowSellersCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowOrdersCommand { get; }
        public ICommand ShowOrderFullInfoCommand { get; }
        public ICommand AddNewSellerCommand { get; }
        public ICommand DeleteSellerCommand { get; }

        public SellerListViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _sellerProvider = new SellerMVMProvider(_simpleShop);

            ShowSellersCommand = new ShowSellersCommand(_navigationService, CreateSellerListViewModel);
            ShowCustomersCommand = new ShowCustomersCommand(_navigationService, CreateCustomerListViewModel);
            ShowOrdersCommand = new ShowOrdersCommand(_navigationService, CreateOrderListViewModel);
            AddNewSellerCommand = new AddNewSellerCommand(_navigationService, CreateSingleSellerViewModel);
            DeleteSellerCommand = new OpenSellerDeleteMenuCommand(_navigationService, CreateSellerDeleteViewModel);

            Sellers = _sellerProvider.GetSellers();
        }

        public override bool NavigationStoreShouldStore()
        {
            return true;
        }
    }
}
