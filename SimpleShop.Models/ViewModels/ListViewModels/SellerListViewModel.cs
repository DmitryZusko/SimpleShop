using SimpleShop.Models.Commands;
using SimpleShop.Models.Commands.AddNewCommands;
using SimpleShop.Models.Commands.ShowCommands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services;
using SimpleShop.Models.Services.ModelViewModelConverter;
using SimpleShop.Models.ViewModels.ClassViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.ListViewModels
{
    public class SellerListViewModel : ViewModelCommandsBase
    {
        public ObservableCollection<SellerViewModel> Sellers { get; set; }
        public SellerViewModel BindedSeller { get; set; }
        public ICommand ShowSellersCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowOrdersCommand { get; }
        public ICommand ShowOrderFullInfoCommand { get; }
        public ICommand AddNewSellerCommand { get; }
        public ICommand DeleteSellerCommand { get; }

        private readonly MVVMConverter _mvmConverter;

        public SellerListViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _mvmConverter = new MVVMConverter();

            Sellers = _mvmConverter.FromModelToVM<Seller, SellerViewModel>(simpleShop.GetSellersList());

            ShowSellersCommand = new ShowSellersCommand(_navigationService, CreateSellerListViewModel);
            ShowCustomersCommand = new ShowCustomersCommand(_navigationService, CreateCustomerListViewModel);
            ShowOrdersCommand = new ShowOrdersCommand(_navigationService, CreateOrderListViewModel);
            //ShowOrderFullInfoCommand = new ShowOrderFullInfoCommand(NavigationService);
            AddNewSellerCommand = new AddNewSellerCommand(_navigationService, CreateSingleSellerViewModel);
            //DeleteSellerCommand = new DeleteSellerCommand(NavigationService);
        }

        public override bool NavigationStoreShouldStore()
        {
            return true;
        }
    }
}
