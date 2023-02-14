using AutoMapper;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;

namespace SimpleShop.Models.Services.DatabaseServices
{
    public abstract class DatabaseServiceBase : IDatabaseService
    {
        private readonly MapperConfiguration _config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Seller, SellerDTO>();
            cfg.CreateMap<Customer, CustomerDTO>();
            cfg.CreateMap<Order, OrderDTO>();
        });

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
                    cfg.CreateProjection<OrderDTO, Order>().
                    ForMember(order => order.SellerFullName, cfg => cfg.MapFrom(dto => dto.Seller.FullName)).
                    ForMember(order => order.CustomerCompany, cfg => cfg.MapFrom(dto => dto.Customer.Company));
                    cfg.CreateProjection<Order, OrderDTO>();
                });
            }
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            IMapper _mapper = new Mapper(_config);
            return _mapper.Map<TSource, TDestination>(source);
        }
    }
}
