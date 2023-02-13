using Microsoft.Data.SqlClient;
using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.DataBaseModel.DTOs;

namespace SimpleShop.Models.Services.DatabaseCreators
{
    public class OrderDatabaseCreator
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
