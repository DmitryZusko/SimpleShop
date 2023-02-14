using SimpleShop.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.MVMServices.MVMRemovers
{
    public class OrderMVMRemover : MVMServiceBase
    {
        private readonly SimpleShopEntity _simpleShop;

        public OrderMVMRemover(SimpleShopEntity simpleShop)
        {
            _simpleShop = simpleShop;
        }

        public void Remove(int id)
        {
            _simpleShop.DeleteOrder(id);
        }
    }
}
