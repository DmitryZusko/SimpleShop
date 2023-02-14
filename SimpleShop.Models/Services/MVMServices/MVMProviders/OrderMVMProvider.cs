using SimpleShop.Models.Models;
using SimpleShop.Models.ViewModels.ClassViewModels;
using SimpleShop.Models.ViewModels.ListViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.MVMServices.MVMProviders
{
    public class OrderMVMProvider : MVMServiceBase
    {
        private readonly SimpleShopEntity _simpleShop;

        public OrderMVMProvider(SimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
        }

        public ObservableCollection<OrderViewModel> GetOrders()
        {
            return new ObservableCollection<OrderViewModel>(_simpleShop.GetOrdersList().Select(o => Map<Order, OrderViewModel>(o)));
        }

        public ObservableCollection<FullOrderViewModel>? GetFullOrders()
        {
            return new ObservableCollection<FullOrderViewModel>(_simpleShop.GetOrdersList().Select(o => Map<Order, FullOrderViewModel>(o)));
        }
    }
}
