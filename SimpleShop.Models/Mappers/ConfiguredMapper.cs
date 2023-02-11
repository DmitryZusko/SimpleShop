using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SimpleShop.Models.Models;
using SimpleShop.Models.ViewModels;
using SimpleShop.Models.ViewModels.ClassViewModels;
using SimpleShop.Models.ViewModels.SingleEntityViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Mappers
{
    public static class ConfiguredMapper
    {
        public static MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Seller, SellerViewModel>().ReverseMap();
            cfg.CreateMap<Customer, SingleCustomerViewModel>().ReverseMap();
            cfg.CreateMap<Order, SingleOrderViewModel>().ReverseMap();
        });
    }
}
