using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;

namespace SimpleShop.Models.Services.DatabaseServices.DatabaseRemovers
{
    internal class CustomerDatabaseRemover : DatabaseServiceBase
    {
        internal void Remove(Customer customer)
        {
            using (var context = new DatabaseContext())
            {
                context.Customers.Remove(Map<Customer, CustomerDTO>(customer));
                context.SaveChanges();
            }
        }
    }
}
