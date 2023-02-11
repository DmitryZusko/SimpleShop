using AutoMapper.QueryableExtensions;
using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.Models.Mappers;
using SimpleShop.Models.Models;

namespace SimpleShop.Models.Services.DatabaseProviders
{
    public class CustomerDatabaseProvider
    {
        private readonly QueryableMapper _mapper;
        public CustomerDatabaseProvider()
        {
            _mapper = new QueryableMapper();
        }

        public List<Customer> LoadTable()
        {
            using (var context = new DatabaseContext())
            {
                return context.Customers.ProjectTo<Customer>(_mapper.config).ToList();
            }
        }
    }
}
