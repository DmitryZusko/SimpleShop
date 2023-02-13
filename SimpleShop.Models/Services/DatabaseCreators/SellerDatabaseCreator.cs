using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.DataBaseModel.DTOs;

namespace SimpleShop.Models.Services.DatabaseCreators
{
    public class SellerDatabaseCreator
    {
        public SellerDTO AddNew(SellerDTO newSeller)
        {
            using (var context = new DatabaseContext())
            {
                context.Sellers.Add(newSeller);
                context.SaveChanges();
                return newSeller;
            }
        }
    }
}
