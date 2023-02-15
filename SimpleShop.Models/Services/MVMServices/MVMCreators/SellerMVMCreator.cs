namespace SimpleShop.Models.Services.MVMServices.MVMCreators
{
    using SimpleShop.Models.Models;
    using SimpleShop.Models.ViewModels.ClassViewModels;
    /// <summary>
    /// Hangs over adding new seller operation from ViewModel to Model.
    /// </summary>
    public class SellerMVMCreator : MVMServiceBase
    {
        private readonly SimpleShopEntity _simpleShop;

        public SellerMVMCreator(SimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
        }

        public void AddNew(SellerViewModel newSeller)
        {
            _simpleShop.AddSeller(Map<SellerViewModel, Seller>(newSeller));
        }
    }
}
