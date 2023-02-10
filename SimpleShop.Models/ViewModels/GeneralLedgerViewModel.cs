using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels
{
    public class GeneralLedgerViewModel : ViewModelBase
    {
        private readonly ObservableCollection<SellerViewModel> _sellers;
        public IEnumerable<SellerViewModel> Sellers => _sellers;
        private readonly ObservableCollection<CustomerViewModel> _customers;
        public IEnumerable<CustomerViewModel> Customers => _customers;
        private readonly ObservableCollection<OrderViewModel> _orders;
        public IEnumerable<OrderViewModel> Orders => _orders;

        public ICommand ShowSellersCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowOrdersCommand { get;}
        public ICommand ShowOrderFullInfoCommand { get; }
        public ICommand AddNewSellerCommand { get; }
        public ICommand AddNewCustomerCommand { get; }
        public ICommand AddNewOrderCommand { get; }
        public ICommand UpdateSellerCommand { get; }
        public ICommand UpdateCustomerCommand { get; }
        public ICommand DeleteSellerCommand { get; }
        public ICommand cDeleteSellercommand { get; }
        public ICommand DeleteCustomerCommand { get; }
        public ICommand DeleteOrderCommand { get; }
    }
}
