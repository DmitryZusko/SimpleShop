using SimpleShop.Models.Models;
using SimpleShop.Models.Services.Validatiors;

namespace SimpleShop.Models.Services.MVMServices.MVMRemovers
{
    public class SellerMVMRemover : MVMServiceBase
    {
        private readonly SimpleShopEntity _simpleShop;
        private readonly IdentificatorValidator _idValidatior;

        public SellerMVMRemover(SimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
            _idValidatior = new IdentificatorValidator(_simpleShop);

        }

        public void Remove(int id)
        {
            if (_idValidatior.Validate(id, IdentificatorValidator.ValidationMode.seller))
            {
                _simpleShop.DeleteSeller(id);
            }
        }
    }
}
