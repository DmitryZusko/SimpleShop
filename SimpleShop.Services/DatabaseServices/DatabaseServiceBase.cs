namespace SimpleShop.Models.Services.DatabaseServices
{
    using AutoMapper;
    using SimpleShop.DataBaseModel.DTOs;
    using SimpleShop.Models.Models;
    /// <summary>
    /// Base class for all DataBase Services. Contain configurations fro different mappings.
    /// </summary>
    public abstract class DatabaseServiceBase : IDatabaseService
    {
        /// <summary>
        /// Contains configurations for mappings from models to DTOs.
        /// </summary>
        private readonly MapperConfiguration _config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Seller, SellerDTO>();
            cfg.CreateMap<Customer, CustomerDTO>();
            cfg.CreateMap<Order, OrderDTO>();
        });
        /// <summary>
        /// Configuration for <c>ProjectTo<></c> mapping, that allows map DTOs to models better, than standart <c>mapper.Map<>()</c>.
        /// </summary>
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
        /// <summary>
        /// Map method for mapings described in <c>_config</c>> property.
        /// </summary>
        /// <typeparam name="TSource"> Cource type.</typeparam>
        /// <typeparam name="TDestination"> Destination type.</typeparam>
        /// <param name="source">Source object.</param>
        /// <returns> Returns source object mapped in <typeparamref name="TDestination"/> type.</returns>
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            IMapper _mapper = new Mapper(_config);
            return _mapper.Map<TSource, TDestination>(source);
        }
    }
}
