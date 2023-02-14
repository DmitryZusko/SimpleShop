using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.ModelViewModelConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.DatabaseServices.DatabaseRemovers
{
    internal class SellerDatabaseRemover : DatabaseServiceBase
    {
        public void Remove(Seller seller)
        {
            using (var context = new DatabaseContext())
            {
                context.Sellers.Remove(Map<SellerDTO>(seller));
                context.SaveChanges();
            }
        }
    }
}
