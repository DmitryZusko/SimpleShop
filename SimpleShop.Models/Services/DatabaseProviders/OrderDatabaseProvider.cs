using AutoMapper.QueryableExtensions;
using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.Models.Mappers;
using SimpleShop.Models.Models;

namespace SimpleShop.Models.Services.DatabaseProviders
{
    public class OrderDatabaseProvider
    {
        private readonly QueryableMapper _mapper;
        public OrderDatabaseProvider()
        {
            _mapper = new QueryableMapper();
        }
        public List<Order> LoadTable()
        {
            using (var context = new DatabaseContext())
            {
                return context.Orders.ProjectTo<Order>(_mapper.config).ToList();
            }
        }
    }
}
