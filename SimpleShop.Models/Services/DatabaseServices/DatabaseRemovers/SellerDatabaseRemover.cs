using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;

namespace SimpleShop.Models.Services.DatabaseServices.DatabaseRemovers
{
    internal class SellerDatabaseRemover : DatabaseServiceBase
    {
        public void Remove(Seller seller)
        {
            using (var context = new DatabaseContext())
            {
                context.Sellers.Remove(Map<Seller, SellerDTO>(seller));
                context.SaveChanges();
            }
        }
    }
}
