using SimpleShop.Models.Models;
using SimpleShop.Models.ViewModels.ClassViewModels;
using System.Collections.ObjectModel;

namespace SimpleShop.Models.Services.MVMServices.MVMProviders
{
    public class SellerMVMProvider : MVMServiceBase
    {
        private SimpleShopEntity _simpleShop;

        public SellerMVMProvider(SimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
        }

        public ObservableCollection<SellerViewModel> GetSellers()
        {
            return new ObservableCollection<SellerViewModel>(_simpleShop.GetSellersList().Select(s => Map<Seller, SellerViewModel>(s)));
        }
    }
}
