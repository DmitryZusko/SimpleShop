using AutoMapper.QueryableExtensions;
using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Mappers;
using SimpleShop.Models.Models;

namespace SimpleShop.Models.Services.DatabaseProviders
{
    public class SellersDatabaseProvider
    {
        private readonly QueryableMapper _mapper;
        public SellersDatabaseProvider()
        {
            _mapper = new QueryableMapper();
        }
        public List<Seller> LoadTable()
        {
            var sellerList = new List<IModel>();
            using (var context = new DatabaseContext())
            {
                return context.Sellers.ProjectTo<Seller>(_mapper.config).ToList();
            }
        }

    }
}
