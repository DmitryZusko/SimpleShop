﻿using SimpleShop.Models.Models;
using SimpleShop.Models.Services;
using SimpleShop.Models.ViewModels.ClassViewModels;
using SimpleShop.Models.ViewModels.ListViewModels;
using SimpleShop.Models.ViewModels.SingleEntityViewModel;
using SimpleShop.Models.ViewModels.UpdateViewModels;

namespace SimpleShop.Models.ViewModels
{
    public abstract class ViewModelCommandsBase : ViewModelBase
    {
        protected SimpleShopEntity _simpleShop;
        protected NavigationService _navigationService;
        protected ViewModelCommandsBase(NavigationService navigationService, SimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
            _navigationService = navigationService;
        }

        public SellerListViewModel CreateSellerListViewModel()
        {
            return new SellerListViewModel(_navigationService, _simpleShop);
        }

        public CustomerListViewModel CreateCustomerListViewModel()
        {
            return new CustomerListViewModel(_navigationService, _simpleShop);
        }

        public OrderListViewModel CreateOrderListViewModel()
        {
            return new OrderListViewModel(_navigationService, _simpleShop);
        }

        public SingleSellerViewModel CreateSingleSellerViewModel()
        {
            return new SingleSellerViewModel(_navigationService, _simpleShop);
        }

        public SingleCustomerViewModel CreateSingleCustomerViewModel()
        {
            return new SingleCustomerViewModel(_navigationService, _simpleShop);
        }

        public SingleOrderViewModel CreateSingleOrderViewModel()
        {
            return new SingleOrderViewModel(_navigationService, _simpleShop);
        }

        public UpdateSellerViewModel CreateBindedSellerViewModel(ViewModelBase bindedSeller)
        {
            return new UpdateSellerViewModel(_navigationService, _simpleShop, bindedSeller);
        }

        public UpdateCustomerViewModel CreateBindedCustomerViewModel(ViewModelBase bindedCustomer)
        {
            return new UpdateCustomerViewModel(_navigationService, _simpleShop, bindedCustomer);
        }

        public UpdateOrderViewModel CreatBindedOrderViewModel(OrderViewModel bindedOrder)
        {
            return new UpdateOrderViewModel(_navigationService, _simpleShop, bindedOrder);
        }
    }
}
