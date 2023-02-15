using SimpleShop.Models.Models;
using SimpleShop.Models.Services.Validatiors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.MVMServices.MVMRemovers
{
    public class CustomerMVMRemover
    {
        private readonly SimpleShopEntity _simpleShop;
        private readonly IdentificatorValidator _idValidator;

        public CustomerMVMRemover(SimpleShopEntity simpleShop)
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
