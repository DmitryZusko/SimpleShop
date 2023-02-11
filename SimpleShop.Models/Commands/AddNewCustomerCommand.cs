using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;

namespace SimpleShop.Models.Commands
{
    public class AddNewCustomerCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        public AddNewCustomerCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new CustomerViewModel(_navigationStore);
        }
    }
}
