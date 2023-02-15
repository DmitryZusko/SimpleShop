using AutoMapper.QueryableExtensions;
using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.Models.Models;

namespace SimpleShop.Models.Services.DatabaseServices.DatabaseProviders
{
    public class OrderDatabaseProvider : DatabaseServiceBase
    {
        public List<Order> LoadTable()
        {
            using (var context = new DatabaseContext())
            {
                return context.Orders.ProjectTo<Order>(QuerybleConfig).ToList();
            }
        }
        public Order GetOrder(int id)
        {
            using (var context = new DatabaseContext())
            {

                return context.Orders.ProjectTo<Order>(QuerybleConfig).FirstOrDefault(o => o.ID == id);
            }
        }
    }
}
