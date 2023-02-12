using SimpleShop.Models.Models;
using SimpleShop.Models.Services;
using SimpleShop.Models.ViewModels.ClassViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.ViewModels.UpdateViewModels
{
    public class UpdateCustomerViewModel : ViewModelCommandsBase
    {
        public ViewModelBase CustomerToUpdate { get; set; }

        public UpdateCustomerViewModel(NavigationService navigationService, SimpleShopEntity simpleShop, ViewModelBase bindedCustomer) : base(navigationService, simpleShop)
        {
            CustomerToUpdate = bindedCustomer;
        }
    }
}
