using SimpleShop.Models.Commands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels.ClassViewModels;
using SimpleShop.Models.ViewModels.SingleEntityViewModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.ListViewModels
{
    public class CustomerListViewModel : ViewModelCommandsBase
    {
        public ObservableCollection<CustomerViewModel> Customers { get; set; } = new ObservableCollection<CustomerViewModel>();
        public ICommand ShowSellersCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowOrdersCommand { get; }
        public ICommand ShowOrderFullInfoCommand { get; }
        public ICommand AddNewCustomerCommand { get; }
        public ICommand UpdateCustomerCommand { get; }
        public ICommand DeleteCustomerCommand { get; }
        public CustomerListViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            ShowSellersCommand = new ShowSellersCommand(_navigationService, CreateSellerListViewModel);
            ShowCustomersCommand = new ShowCustomersCommand(_navigationService, CreateCustomerListViewModel);
            ShowOrdersCommand = new ShowOrdersCommand(_navigationService, CreateOrderListViewModel);
            //ShowOrderFullInfoCommand = new ShowOrderFullInfoCommand(_navigationService, Cre);
            AddNewCustomerCommand = new AddNewCustomerCommand(_navigationService, CreateSingleCustomerViewModel);
            UpdateCustomerCommand = new UpdateCustomerCommand(_navigationService, CreateSingleCustomerViewModel);
            //DeleteCustomerCommand = new DeleteCustomercommand(_navigationService);
        }

        public override bool NavigationStoreShouldStore()
        {
            return true;
        }
    }
}
