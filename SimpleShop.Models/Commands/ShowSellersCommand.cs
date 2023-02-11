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
    public class ShowSellersCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly Func<ViewModelBase> _createSelerListViewModel;

        public ShowSellersCommand(NavigationService navigationService, Func<ViewModelBase> createSelerListViewModel)
        {
            _navigationService = navigationService;
            _createSelerListViewModel = createSelerListViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.CreateViewModel(_createSelerListViewModel);
        }
    }
}
