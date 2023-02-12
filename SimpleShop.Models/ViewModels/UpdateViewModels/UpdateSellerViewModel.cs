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
    public class UpdateSellerViewModel : ViewModelCommandsBase
    {
        public ViewModelBase SellerToUpdate { get; set; }

        public UpdateSellerViewModel(NavigationService navigationService, SimpleShopEntity simpleShop, ViewModelBase bindedSeller) : base(navigationService, simpleShop)
        {
            SellerToUpdate = bindedSeller;
        }


    }
}
