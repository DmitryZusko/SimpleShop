using SimpleShop.Models.Services;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Commands
{
    internal class UpdateSellerCommand : CommandBase
    {
        private NavigationService _navigationService;
        private Func<ViewModelBase> _sellerViewModel;

        public UpdateSellerCommand(NavigationService navigationService, Func<ViewModelBase> sellerViewModel)
        {
            _navigationService = navigationService;
            _sellerViewModel = sellerViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.CreateViewModel(_sellerViewModel);
        }
    }
}
