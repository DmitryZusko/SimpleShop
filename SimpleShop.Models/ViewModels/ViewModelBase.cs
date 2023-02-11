using SimpleShop.Models.Models;
using SimpleShop.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged, IStorePreviousViewModel
    {
        public NavigationService NavigationService { get; set; }
        public SimpleShopEntity SimpleShop { get; set; }
        public ViewModelBase() { }
        public  ViewModelBase(NavigationService navigationService, SimpleShopEntity simpleShop)
        {
            NavigationService = navigationService;
            SimpleShop = simpleShop;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual bool NavigationStoreShouldStore()
        {
            return false;
        }

        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public SellerListViewModel CreateSellerListViewModel()
        {
            return new SellerListViewModel(NavigationService, SimpleShop);
        }

        public CustomerListViewModel CreateCustomerListViewModel()
        {
            return new CustomerListViewModel(NavigationService, SimpleShop);
        }

        public OrderListViewModel CreateOrderListViewModel()
        {
            return new OrderListViewModel(NavigationService, SimpleShop);
        }

        public SellerViewModel CreateSellerviewModel()
        {
            return new SellerViewModel(NavigationService, SimpleShop);
        }

        public CustomerViewModel CreateCustomerViewModel()
        {
            return new CustomerViewModel(NavigationService, SimpleShop);
        }

        public OrderViewModel CreateOrderViewModel()
        {
            return new OrderViewModel(NavigationService, SimpleShop);
        }
    }
}
