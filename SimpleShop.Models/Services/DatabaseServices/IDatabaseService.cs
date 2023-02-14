using AutoMapper;
using AutoMapper.Configuration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.DatabaseServices
{
    public interface IDatabaseService
    {
        public MapperConfiguration QuerybleConfig { get; }

        public TDestination Map<TSource, TDestination>(TSource source);
    }
}
