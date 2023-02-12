using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Commands.DeleteCommands
{
    public class OpenSellerDeleteMenuCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly Func<ViewModelBase> _createNewViewModel;
        public OpenSellerDeleteMenuCommand(NavigationService navigationService, Func<ViewModelBase> createNewViewModel)
        {
            _navigationService = navigationService;
            _createNewViewModel = createNewViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.CreateViewModel(_createNewViewModel);
        }
    }
}
