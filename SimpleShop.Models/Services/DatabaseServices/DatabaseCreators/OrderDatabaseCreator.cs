using AutoMapper.QueryableExtensions;
using Microsoft.Data.SqlClient;
using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;

namespace SimpleShop.Models.Services.DatabaseServices.DatabaseCreators
{
    public class OrderDatabaseCreator : DatabaseServiceBase
    {
        public Order AddNew(Order newOrder)
        {
            using (var context = new DatabaseContext())
            {
                var newOrderDTO = Map<Order, OrderDTO>(newOrder);
                context.Orders.Add(newOrderDTO);
                context.SaveChanges();
                return context.Orders.ProjectTo<Order>(QuerybleConfig).FirstOrDefault(o => o.ID == newOrderDTO.ID);
            }
        }
    }
}
