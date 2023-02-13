using AutoMapper.QueryableExtensions;
using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.Models.Models;
using System.Linq;

namespace SimpleShop.Models.Services.DatabaseServices.DatabaseProviders
{
    public class SellersDatabaseProvider : DatabaseServiceBase
    {
        public List<Seller> LoadTable()
        {
            using (var context = new DatabaseContext())
            {
                return context.Sellers.ProjectTo<Seller>(QuerybleConfig).ToList();
            }
        }
        public Seller GetSeller(int id)
        {
            using (var context = new DatabaseContext())
            {
                return context.Sellers.ProjectTo<Seller>(QuerybleConfig).FirstOrDefault(s => s.ID == id);
            }
        }
    }
}
