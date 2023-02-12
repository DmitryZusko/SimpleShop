using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Commands
{
    public class CancelCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        public CancelCommand(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.ReturnToPreviousViewModel();
        }
    }
}
