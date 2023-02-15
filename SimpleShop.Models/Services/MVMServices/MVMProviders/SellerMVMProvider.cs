namespace SimpleShop.Models.Services.MVMServices.MVMProviders
{
    using SimpleShop.Models.Models;
    using SimpleShop.Models.ViewModels.ClassViewModels;
    using System.Collections.ObjectModel;
    /// <summary>
    /// Loads sellers from Model to ViewModel.
    /// </summary>
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
