using SimpleShop.Models.Models;
using SimpleShop.Models.ViewModels.ClassViewModels;

namespace SimpleShop.Models.Services.MVMServices.MVMCreators
{
    public class OrderMVMCreator : MVMServiceBase
    {
        private readonly SimpleShopEntity _simpleShop;

        public OrderMVMCreator(SimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
        }

        public void AddNew(FullOrderViewModel newOrder)
        {
            _simpleShop.AddOrder(Map<FullOrderViewModel, Order>(newOrder));
        }
    }
}
