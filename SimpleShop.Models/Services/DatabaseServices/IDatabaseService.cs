using AutoMapper;
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
    }
}
