using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;

namespace SimpleShop.Models.Commands
{
    public class ShowOrdersCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        public ShowOrdersCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new OrderListViewModel(_navigationStore);
        }
    }
}
