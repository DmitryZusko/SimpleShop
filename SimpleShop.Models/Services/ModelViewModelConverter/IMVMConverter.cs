using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.ModelViewModelConverter
{
    public interface IMVMConverter
    {
        public ObservableCollection<TDestination> FromModelToVM<TSource, TDestination>(List<TSource> source);
        public List<TDestination> FromVMToModel<TSource, TDestination>(ObservableCollection<TSource> source);
        public TDestination Map<TDestination>(object source);
    }
}
