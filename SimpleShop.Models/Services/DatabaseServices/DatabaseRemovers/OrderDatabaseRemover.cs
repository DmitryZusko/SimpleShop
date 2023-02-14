using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;

namespace SimpleShop.Models.Services.DatabaseServices.DatabaseRemovers
{
    internal class OrderDatabaseRemover : DatabaseServiceBase
    {
        public void Remove(Order order)
        {
            using (var context = new DatabaseContext())
            {
                context.Orders.Remove(Map<Order, OrderDTO>(order));
                context.SaveChanges();
            }
        }
    }
}
