namespace SimpleShop.Models.Services.DatabaseServices.DatabaseRemovers
{
    using SimpleShop.DataBaseModel.DBContext;
    using SimpleShop.DataBaseModel.DTOs;
    using SimpleShop.Models.Models;
    /// <summary>
    /// Allows to connect DataBase and remove certain customer from related table.
    /// </summary>
    internal class CustomerDatabaseRemover : DatabaseServiceBase
    {
        public void Remove(Customer customer)
        {
            using (var context = new DatabaseContext())
            {
                context.Customers.Remove(Map<Customer, CustomerDTO>(customer));
                context.SaveChanges();
            }
        }
    }
}
