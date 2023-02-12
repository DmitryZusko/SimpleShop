using SimpleShop.Models.Services;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Commands
{
    internal class UpdateSellerCommand : CommandBase
    {
        private NavigationService _navigationService;
        private Func<ViewModelBase, ViewModelBase> _sellerViewModel;
        private readonly ViewModelBase _bindedViewModel;

        public UpdateSellerCommand(NavigationService navigationService, ViewModelBase bindedViewModel, Func<ViewModelBase, ViewModelBase> newViewModel)
        {
            _navigationService = navigationService;
            _sellerViewModel = newViewModel;
            _bindedViewModel = bindedViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.CreateBindedViewModel(_sellerViewModel, _bindedViewModel);
        }
    }
}
