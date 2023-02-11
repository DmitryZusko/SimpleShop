using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;

namespace SimpleShop.Models.Commands
{
    internal class AddNewOrderCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public AddNewOrderCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new OrderViewModel(_navigationStore);
        }
    }
}
