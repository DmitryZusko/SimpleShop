using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Commands
{
    public class ShowSellersCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        public ShowSellersCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new SellerListViewModel(_navigationStore);
        }
    }
}
