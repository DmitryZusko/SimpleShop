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
        public bool Validate(int id, GeneralLedger generalLedger, ValidationMode mode)
        {
            switch (mode)
            {
                case ValidationMode.seller:
                    {
                        return generalLedger.GetSellersList().Where(s => s.ID == id).Count() > 0;
                    }
                case ValidationMode.customer:
                    {
                        return generalLedger.GetCustomersList().Where(c => c.ID == id).Count() > 0;
                    }
                case ValidationMode.order:
                    {
                        return generalLedger.GetOrdersList().Where(o => o.ID == id).Count() > 0;
                    }
                default:
                    return false;
            }
        }
    }
}
