using AutoMapper;
using SimpleShop.Models.Models;
using SimpleShop.Models.ViewModels.ClassViewModels;
using SimpleShop.Models.ViewModels.ListViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.MVMServices
{
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
