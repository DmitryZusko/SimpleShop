namespace SimpleShop.Models.Services.MVMServices.MVMRemovers
{
    using SimpleShop.Models.Models;
    using SimpleShop.Models.Services.Validatiors;
    /// <summary>
    /// Hangs over deleting seller operation from ViewModel to Model.
    /// </summary>
    public class SellerMVMRemover : MVMServiceBase
    {
        private readonly ISimpleShopEntity _simpleShop;
        private readonly IdentificatorValidator _idValidatior;

        public SellerMVMRemover(ISimpleShopEntity simpleShop)
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
