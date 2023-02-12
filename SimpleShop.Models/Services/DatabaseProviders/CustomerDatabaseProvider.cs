using AutoMapper.QueryableExtensions;
using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.Models.Models;
using SimpleShop.Models.ViewModels.ClassViewModels;

namespace SimpleShop.Models.Services.DatabaseProviders
{
    public class CustomerDatabaseProvider : ProviderMapperBase
    {
        public List<Customer> LoadTable()
        {
            using (var context = new DatabaseContext())
            {
                return context.Customers.ProjectTo<Customer>(QuerybleConfig).ToList();
            }
        }

        public Customer Find(string newCustomer)
        {
            using(var context = new DatabaseContext())
            {
                return context.Customers.ProjectTo<Customer>(QuerybleConfig).FirstOrDefault(c => c.Company == newCustomer);
            }
        }
    }
}
