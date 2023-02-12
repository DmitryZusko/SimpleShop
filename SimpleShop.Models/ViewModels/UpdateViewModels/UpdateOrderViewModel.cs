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
    public class UpdateOrderViewModel : ViewModelCommandsBase
    {
        public OrderViewModel OrderToUpdate { get; set; }
        public UpdateOrderViewModel(NavigationService navigationService, SimpleShopEntity simpleShop, OrderViewModel bindedOrder) : base(navigationService, simpleShop)
        {
            OrderToUpdate = bindedOrder;
        }
    }
}
