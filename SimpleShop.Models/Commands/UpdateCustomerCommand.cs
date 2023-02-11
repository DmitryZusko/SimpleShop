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
    public class UpdateCustomerCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly Func<ViewModelBase> _customerViewModel;

        public UpdateCustomerCommand(NavigationService navigationStore, Func<ViewModelBase> customerViewModel)
        {
            _navigationService = navigationStore;
            _customerViewModel = customerViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.CreateViewModel(_customerViewModel);
        }
    }
}
