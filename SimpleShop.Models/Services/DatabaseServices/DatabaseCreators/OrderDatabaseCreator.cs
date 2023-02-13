using Microsoft.Data.SqlClient;
using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.DataBaseModel.DTOs;

namespace SimpleShop.Models.Services.DatabaseServices.DatabaseCreators
{
    public class OrderDatabaseCreator : DatabaseServiceBase
    {
        public OrderDTO AddNew(OrderDTO newOrder)
        {
            using (var context = new DatabaseContext())
            {
                context.Orders.Add(newOrder);
                context.SaveChanges();
                return newOrder;
            }
        }
    }
}
