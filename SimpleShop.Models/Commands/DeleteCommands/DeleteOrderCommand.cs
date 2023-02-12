using SimpleShop.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Commands.DeleteCommands
{
    internal class DeleteOrderCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public DeleteOrderCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
