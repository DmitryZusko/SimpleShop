namespace SimpleShop.Models.Services.DatabaseServices.DatabaseProviders
{
    using AutoMapper.QueryableExtensions;
    using SimpleShop.DataBaseModel.DBContext;
    using SimpleShop.Models.Models;
    /// <summary>
    /// Allows to connect DataBase and get customers from related table.
    /// </summary>
    public class CustomerDatabaseProvider : DatabaseServiceBase
    {
        public List<Customer> LoadTable()
        {
            using (var context = new DatabaseContext())
            {
                return context.Customers.ProjectTo<Customer>(QuerybleConfig).ToList();
            }
        }
        public Customer GetCustomer(int id)
        {
            using (var context = new DatabaseContext())
            {
                return context.Customers.ProjectTo<Customer>(QuerybleConfig).FirstOrDefault(c => c.ID == id);
            }
        }
    }
}
