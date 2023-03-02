namespace SimpleShop.Models.Services.MVMServices.MVMProviders
{
    using SimpleShop.Models.Models;
    using SimpleShop.Models.ViewModels.ClassViewModels;
    using System.Collections.ObjectModel;
    /// <summary>
    /// Loads orders from Model to ViewModel.
    /// </summary>
    public class OrderMVMProvider : MVMServiceBase
    {
        private readonly ISimpleShopEntity _simpleShop;

        public OrderMVMProvider(ISimpleShopEntity simpleShop)
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
