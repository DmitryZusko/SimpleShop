using Microsoft.Identity.Client;
using SimpleShop.Models.Commands;
using SimpleShop.Models.Services;
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
        private readonly ObservableCollection<SellerViewModel> _sellers;
        public ObservableCollection<SellerViewModel> Sellers => _sellers;
        public ICommand ShowSellersCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowOrdersCommand { get; }
        public ICommand ShowOrderFullInfoCommand { get; }
        public ICommand AddNewSellerCommand { get; }
        public ICommand UpdateSellerCommand { get; }
        public ICommand DeleteSellerCommand { get; }

        public SellerListViewModel(NavigationService navigationService) : base(navigationService)
        {
            ShowSellersCommand = new ShowSellersCommand(NavigationService, CreateSellerListViewModel);
            ShowCustomersCommand = new ShowCustomersCommand(NavigationService, CreateCustomerListViewModel);
            ShowOrdersCommand = new ShowOrdersCommand(NavigationService, CreateOrderListViewModel);
            //ShowOrderFullInfoCommand = new ShowOrderFullInfoCommand(NavigationService);
            AddNewSellerCommand = new AddNewSellerCommand(NavigationService, CreateSellerviewModel);
            UpdateSellerCommand = new UpdateSellerCommand(NavigationService, CreateSellerviewModel);
            //DeleteSellerCommand = new DeleteSellerCommand(NavigationService);
        }

        public override bool NavigationStoreShouldStore()
        {
            return true;
        }
    }
}
