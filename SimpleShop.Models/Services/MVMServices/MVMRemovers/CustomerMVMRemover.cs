namespace SimpleShop.Models.Services.MVMServices.MVMRemovers
{
    using SimpleShop.Models.Models;
    using SimpleShop.Models.Services.Validatiors;
    /// <summary>
    /// Hangs over deleting customer operation from ViewModel to Model.
    /// </summary>
    public class CustomerMVMRemover
    {
        private readonly ISimpleShopEntity _simpleShop;
        private readonly IdentificatorValidator _idValidator;

        public CustomerMVMRemover(ISimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
            _idValidator = new IdentificatorValidator(_simpleShop);
        }

        public void Remove(int id)
        {
            if (_idValidator.Validate(id, IdentificatorValidator.ValidationMode.customer))
            {
                _simpleShop.DeleteCustomer(id);
            }
        }
    }
}
