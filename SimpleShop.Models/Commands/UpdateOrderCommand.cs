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
    internal class UpdateOrderCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly Func<ViewModelBase> _orderViewModel;

        public UpdateOrderCommand(NavigationService navigationStore, Func<ViewModelBase> orderViewModel)
        {
            _navigationService = navigationStore;
            _orderViewModel = orderViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.CreateViewModel(_orderViewModel);
        }
    }
}
