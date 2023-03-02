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
    public class CustomerListViewModel : ViewModelCommandsBase
    {
        private readonly CustomerMVMProvider _customerProvider;
        public ObservableCollection<CustomerViewModel> Customers { get; set; }
        public ICommand ShowSellersCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowOrdersCommand { get; }
        public ICommand ShowOrderFullInfoCommand { get; }
        public ICommand AddNewCustomerCommand { get; }
        public ICommand DeleteCustomerCommand { get; }

        public CustomerListViewModel(NavigationService navigationService, ISimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _customerProvider = new CustomerMVMProvider(_simpleShop);

            ShowSellersCommand = new ShowSellersCommand(_navigationService, CreateSellerListViewModel);
            ShowCustomersCommand = new ShowCustomersCommand(_navigationService, CreateCustomerListViewModel);
            ShowOrdersCommand = new ShowOrdersCommand(_navigationService, CreateOrderListViewModel);
            AddNewCustomerCommand = new AddNewCustomerCommand(_navigationService, CreateSingleCustomerViewModel);
            DeleteCustomerCommand = new OpenCustomerDeleteMenuCommand(_navigationService, CreateCustomerDeleteViewModel);

            Customers = _customerProvider.GetCustomers();
        }
    }
}
