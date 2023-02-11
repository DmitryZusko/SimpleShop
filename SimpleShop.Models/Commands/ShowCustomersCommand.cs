using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;

namespace SimpleShop.Models.Commands
{
    public class ShowCustomersCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        public ShowCustomersCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new CustomerListViewModel(_navigationStore);
        }
    }
}
