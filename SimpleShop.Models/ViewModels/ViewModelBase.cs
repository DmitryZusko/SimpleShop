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
        public NavigationService NavigationService;
        public  ViewModelBase(NavigationService navigationService)
        {
            NavigationService = navigationService;
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
            return new SellerListViewModel(NavigationService);
        }

        public CustomerListViewModel CreateCustomerListViewModel()
        {
            return new CustomerListViewModel(NavigationService);
        }

        public OrderListViewModel CreateOrderListViewModel()
        {
            return new OrderListViewModel(NavigationService);
        }

        public SellerViewModel CreateSellerviewModel()
        {
            return new SellerViewModel(null, NavigationService);
        }

        public CustomerViewModel CreateCustomerViewModel()
        {
            return new CustomerViewModel(NavigationService);
        }

        public OrderViewModel CreateOrderViewModel()
        {
            return new OrderViewModel(NavigationService);
        }
    }
}
