using SimpleShop.Models.Commands;
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
        private readonly NavigationStore _navigationStore;
        public CustomerListViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            ShowSellersCommand = new ShowSellersCommand(_navigationStore);
            ShowCustomersCommand = new ShowCustomersCommand(_navigationStore);
            ShowOrdersCommand = new ShowOrdersCommand(_navigationStore);
            ShowOrderFullInfoCommand = new ShowOrderFullInfoCommand(_navigationStore);
            AddNewCustomerCommand = new AddNewCustomerCommand(_navigationStore);
            UpdateCustomerCommand = new UpdateCustomerCommand(_navigationStore);
            DeleteCustomerCommand = new DeleteCustomercommand(_navigationStore);
        }
    }
}
