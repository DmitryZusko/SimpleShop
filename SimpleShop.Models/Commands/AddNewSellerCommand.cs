using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Commands
{
    internal class AddNewSellerCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public AddNewSellerCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new SellerViewModel(null, _navigationStore);
        }
    }
}
