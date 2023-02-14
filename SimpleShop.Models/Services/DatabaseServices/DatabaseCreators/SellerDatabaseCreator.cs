using AutoMapper.QueryableExtensions;
using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;

namespace SimpleShop.Models.Services.DatabaseServices.DatabaseCreators
{
    public class SellerDatabaseCreator : DatabaseServiceBase
    {
        public Seller AddNew(Seller newSeller)
        {
            using (var context = new DatabaseContext())
            {
                var newSellerDTO = Map<Seller, SellerDTO>(newSeller);
                context.Sellers.Add(newSellerDTO);
                context.SaveChanges();
                return context.Sellers.ProjectTo<Seller>(QuerybleConfig).FirstOrDefault(s => s.ID == newSellerDTO.ID);
            }
        }
    }
}
