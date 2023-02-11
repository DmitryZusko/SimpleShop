using SimpleShop.Models.Commands;
using SimpleShop.Models.Stores;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels
{
    public class OrderListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<OrderViewModel> _orders;
        public ObservableCollection<OrderViewModel> Orders => _orders;
        public ICommand ShowSellersCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowOrdersCommand { get; }
        public ICommand ShowOrderFullInfoCommand { get; }
        public ICommand AddNewOrderCommand { get; }
        public ICommand UpdateOrderCommand { get; }
        public ICommand DeleteOrderCommand { get; }
        private readonly NavigationStore _navigationStore;
        public OrderListViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            ShowSellersCommand = new ShowSellersCommand(_navigationStore);
            ShowCustomersCommand = new ShowCustomersCommand(_navigationStore);
            ShowOrdersCommand = new ShowOrdersCommand(_navigationStore);
            ShowOrderFullInfoCommand = new ShowOrderFullInfoCommand(_navigationStore);
            AddNewOrderCommand = new AddNewOrderCommand(_navigationStore);
            UpdateOrderCommand = new UpdateOrderCommand(_navigationStore);
            DeleteOrderCommand = new DeleteOrderCommand(_navigationStore);
        }
    }
}
