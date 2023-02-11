using SimpleShop.Models.Commands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services;
using SimpleShop.Models.Stores;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels
{
    public class CustomerListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<CustomerViewModel> _customers;
        public IEnumerable<CustomerViewModel> Customers => _customers;
        public ICommand ShowSellersCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowOrdersCommand { get; }
        public ICommand ShowOrderFullInfoCommand { get; }
        public ICommand AddNewCustomerCommand { get; }
        public ICommand UpdateCustomerCommand { get; }
        public ICommand DeleteCustomerCommand { get; }
        public CustomerListViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop) 
        {
            ShowSellersCommand = new ShowSellersCommand(NavigationService, CreateSellerListViewModel);
            ShowCustomersCommand = new ShowCustomersCommand(NavigationService, CreateCustomerListViewModel);
            ShowOrdersCommand = new ShowOrdersCommand(NavigationService, CreateOrderListViewModel);
            //ShowOrderFullInfoCommand = new ShowOrderFullInfoCommand(_navigationService, Cre);
            AddNewCustomerCommand = new AddNewCustomerCommand(NavigationService, CreateCustomerViewModel);
            UpdateCustomerCommand = new UpdateCustomerCommand(NavigationService, CreateCustomerViewModel);
            //DeleteCustomerCommand = new DeleteCustomercommand(_navigationService);
        }

        public override bool NavigationStoreShouldStore()
        {
            return true;
        }
    }
}
