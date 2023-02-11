using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        private readonly NavigationStore _navigationStore;
        public CancelCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.ReturnToPreviousViewModel();
        }
    }
}
