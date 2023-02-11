using SimpleShop.Models.Commands;
using SimpleShop.Models.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels
{
    public class SellerListViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly ObservableCollection<SellerViewModel> _sellers;
        public ObservableCollection<SellerViewModel> Sellers => _sellers;
        public ICommand ShowSellersCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowOrdersCommand { get; }
        public ICommand ShowOrderFullInfoCommand { get; }
        public ICommand AddNewSellerCommand { get; }
        public ICommand UpdateSellerCommand { get; }
        public ICommand DeleteSellerCommand { get; }

        public SellerListViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            ShowSellersCommand = new ShowSellersCommand(_navigationStore);
            ShowCustomersCommand = new ShowCustomersCommand(_navigationStore);
            ShowOrdersCommand = new ShowOrdersCommand(_navigationStore);
            ShowOrderFullInfoCommand = new ShowOrderFullInfoCommand(_navigationStore);
            AddNewSellerCommand = new AddNewSellerCommand(_navigationStore);
            UpdateSellerCommand = new UpdateSellerCommand(_navigationStore);
            DeleteSellerCommand = new DeleteSellerCommand(_navigationStore);
        }
    }
}
