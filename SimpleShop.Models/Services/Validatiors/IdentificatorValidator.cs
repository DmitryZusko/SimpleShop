using SimpleShop.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.Validatiors
{
    public partial class IdentificatorValidator
    {
        private readonly SimpleShopEntity _simpleShop;
        public IdentificatorValidator(SimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
        }
        public bool Validate(int id, ValidationMode mode)
        {
            switch (mode)
            {
                case ValidationMode.seller:
                    {
                        return _simpleShop.GetSellersList().Where(s => s.ID == id).Count() == 1;
                    }
                case ValidationMode.customer:
                    {
                        return _simpleShop.GetCustomersList().Where(c => c.ID == id).Count() == 1;
                    }
                case ValidationMode.order:
                    {
                        return _simpleShop.GetOrdersList().Where(o => o.ID == id).Count() == 1;
                    }
                default:
                    return false;
            }
        }
    }
}
