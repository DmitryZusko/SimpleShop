namespace SimpleShop.Models.Services.DatabaseServices.DatabaseRemovers
{
    using SimpleShop.DataBaseModel.DBContext;
    using SimpleShop.DataBaseModel.DTOs;
    using SimpleShop.Models.Models;
    /// <summary>
    /// Allows to connect DataBase and remove certain order from related table.
    /// </summary>
    public class OrderDatabaseRemover : DatabaseServiceBase
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
