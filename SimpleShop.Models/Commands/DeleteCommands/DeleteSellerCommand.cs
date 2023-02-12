using SimpleShop.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Commands.DeleteCommands
{
    internal class DeleteSellerCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public DeleteSellerCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
