using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.MVMServices
{
    public interface IMVMService
    {
        public TDestination Map<Tsource, TDestination>(Tsource source);
    }
}
