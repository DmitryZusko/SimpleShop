using AutoMapper.QueryableExtensions;
using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.Models.Models;

namespace SimpleShop.Models.Services.DatabaseProviders
{
    public class OrderDatabaseProvider : ProviderMapperBase
    {
        public List<Order> LoadTable()
        {
            using (var context = new DatabaseContext())
            {
                return context.Orders.ProjectTo<Order>(QuerybleConfig).ToList();
            }
        }
    }
}
