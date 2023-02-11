using AutoMapper.QueryableExtensions;
using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.Models.Models;
using System.Linq;

namespace SimpleShop.Models.Services.DatabaseProviders
{
    public class SellersDatabaseProvider : ProviderMapperBase
    {
        public List<Seller> LoadTable()
        {
            using (var context = new DatabaseContext())
            {
                return context.Sellers.ProjectTo<Seller>(QuerybleConfig).ToList();
            }
        }
    }
}
