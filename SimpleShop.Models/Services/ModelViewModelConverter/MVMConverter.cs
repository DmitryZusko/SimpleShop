using AutoMapper;
using SimpleShop.Models.Models;
using SimpleShop.Models.ViewModels.ClassViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.ModelViewModelConverter
{
    public class MVMConverter : IMVMConverter
    {
        private readonly IMapper _mapper;
        public MVMConverter()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Seller, SellerViewModel>().ReverseMap();
                cfg.CreateMap<Customer, CustomerViewModel>().ReverseMap();
                cfg.CreateMap<Order, OrderViewModel>().ReverseMap();
            });

            _mapper = config.CreateMapper();
        }
        public ObservableCollection<TDestination> FromModelToVM<TSource, TDestination>(List<TSource> source)
        {
            if (source != null)
            {
                return new ObservableCollection<TDestination>(source.Select(s => Map<TDestination>(s)));
            }
            return new ObservableCollection<TDestination>();
        }

        public List<TDestination> FromVMToModel<TSource, TDestination>(ObservableCollection<TSource> source)
        {
            var list = new List<TDestination>();
            if (source == null)
            {
                return list;
            }
            foreach (var item in source)
            {
                list.Add(Map<TDestination>(item));
            }
            return list;
        }

        public TDestination Map<TDestination>(object source)
        {
            return _mapper.Map<TDestination>(source);
        }
    }
}
