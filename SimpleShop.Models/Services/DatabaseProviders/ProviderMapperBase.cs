using AutoMapper;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;

namespace SimpleShop.Models.Services.DatabaseProviders
{
    public abstract class ProviderMapperBase
    {
        public MapperConfiguration QuerybleConfig
        {
            get
            {
                return new MapperConfiguration(cfg =>
                {
                    cfg.CreateProjection<SellerDTO, Seller>();
                    cfg.CreateProjection<Seller, SellerDTO>();
                    cfg.CreateProjection<CustomerDTO, Customer>();
                    cfg.CreateProjection<Customer, CustomerDTO>();
                    cfg.CreateProjection<OrderDTO, Order>();
                    cfg.CreateProjection<Order, OrderDTO>();
                });
            }
        }
    }
}
