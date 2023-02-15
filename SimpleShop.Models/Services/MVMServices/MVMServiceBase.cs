namespace SimpleShop.Models.Services.MVMServices
{
    using AutoMapper;
    using SimpleShop.Models.Models;
    using SimpleShop.Models.ViewModels.ClassViewModels;
    /// <summary>
    /// Base class for oll MVMServices. Contains mapping configurations that allows to map between Model and ViewModel.
    /// </summary>
    public class MVMServiceBase : IMVMService
    {
        private readonly MapperConfiguration _config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Seller, SellerViewModel>().ReverseMap();
            cfg.CreateMap<Customer, CustomerViewModel>().ReverseMap();
            cfg.CreateMap<Order, OrderViewModel>().ReverseMap();
            cfg.CreateMap<Order, FullOrderViewModel>().ReverseMap();
        });
        public TDestination Map<Tsource, TDestination>(Tsource source)
        {
            var _mapper = new Mapper(_config);
            return _mapper.Map<Tsource, TDestination>(source);
        }
    }
}
