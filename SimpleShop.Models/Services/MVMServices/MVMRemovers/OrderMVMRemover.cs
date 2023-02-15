using SimpleShop.Models.Models;
using SimpleShop.Models.Services.Validatiors;

namespace SimpleShop.Models.Services.MVMServices.MVMRemovers
{
    public class OrderMVMRemover : MVMServiceBase
    {
        private readonly SimpleShopEntity _simpleShop;
        private readonly IdentificatorValidator _idValidator;

        public OrderMVMRemover(SimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
            _idValidator = new IdentificatorValidator(_simpleShop);
        }

        public void Remove(int id)
        {
            if (_idValidator.Validate(id, IdentificatorValidator.ValidationMode.order))
            {
                _simpleShop.DeleteOrder(id);
            }
        }
    }
}
