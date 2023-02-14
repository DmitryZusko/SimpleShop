using SimpleShop.Models.Models;
using SimpleShop.Models.ViewModels.ClassViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.MVMServices.MVMCreators
{
    public class CustomerMVMCreator : MVMServiceBase
    {
        private readonly SimpleShopEntity _simpleShop;

        public CustomerMVMCreator(SimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
        }

        public void AddNew(CustomerViewModel newCustomer)
        {
            _simpleShop.AddCustomer(Map<CustomerViewModel, Customer>(newCustomer));
        }
    }
}
