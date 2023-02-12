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
    public class CustomerListViewModel : ViewModelCommandsBase
    {
        public ObservableCollection<CustomerViewModel> Customers { get; set; }
        public CustomerViewModel SelectedCustomer { get; set; }
        public ICommand ShowSellersCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowOrdersCommand { get; }
        public ICommand ShowOrderFullInfoCommand { get; }
        public ICommand AddNewCustomerCommand { get; }
        public ICommand DeleteCustomerCommand { get; }

        private MVVMConverter _mvmConverter;
        public CustomerListViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _mvmConverter = new MVVMConverter();

            Customers = _mvmConverter.FromModelToVM<Customer, CustomerViewModel>(_simpleShop.GetCustomersList());

            ShowSellersCommand = new ShowSellersCommand(_navigationService, CreateSellerListViewModel);
            ShowCustomersCommand = new ShowCustomersCommand(_navigationService, CreateCustomerListViewModel);
            ShowOrdersCommand = new ShowOrdersCommand(_navigationService, CreateOrderListViewModel);
            //ShowOrderFullInfoCommand = new ShowOrderFullInfoCommand(_navigationService, Cre);
            AddNewCustomerCommand = new AddNewCustomerCommand(_navigationService, CreateSingleCustomerViewModel);
            //DeleteCustomerCommand = new DeleteCustomercommand(_navigationService);
        }

        public override bool NavigationStoreShouldStore()
        {
            return true;
        }
    }
}
