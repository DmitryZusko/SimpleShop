namespace SimpleShop.Models.Services.DatabaseServices.DatabaseProviders
{
    using AutoMapper.QueryableExtensions;
    using SimpleShop.DataBaseModel.DBContext;
    using SimpleShop.Models.Models;
    /// <summary>
    /// Allows to connect DataBase and get orders from related table.
    /// </summary>
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
