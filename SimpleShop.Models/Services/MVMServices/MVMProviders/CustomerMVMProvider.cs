using SimpleShop.Models.Models;
using SimpleShop.Models.ViewModels.ClassViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.MVMServices.MVMProviders
{
    public class CustomerMVMProvider : MVMServiceBase
    {
        private readonly SimpleShopEntity _simpleShop;

        public CustomerMVMProvider(SimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
        }

        public ObservableCollection<CustomerViewModel> GetCustomers()
        {
            return new ObservableCollection<CustomerViewModel>(_simpleShop.GetCustomersList().Select(c => Map<Customer, CustomerViewModel>(c)));
        }
    }
}
