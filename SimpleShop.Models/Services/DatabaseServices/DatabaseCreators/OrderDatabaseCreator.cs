namespace SimpleShop.Models.Services.DatabaseServices.DatabaseCreators
{
    using AutoMapper.QueryableExtensions;
    using SimpleShop.DataBaseModel.DBContext;
    using SimpleShop.DataBaseModel.DTOs;
    using SimpleShop.Models.Models;

    public class OrderDatabaseCreator : DatabaseServiceBase
    {
        /// <summary>
        /// Allows to connect DataBase and add new <c>OrderDTO</c> into related table.
        /// </summary>
        /// <returns>
        /// Returns newly added <c>OrderDTO</c>, mapped to an <c>Order</c> type.
        /// </returns>
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
