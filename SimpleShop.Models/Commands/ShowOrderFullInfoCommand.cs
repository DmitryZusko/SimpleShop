using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels.ListViewModels;

namespace SimpleShop.Models.Commands
{
    public class ShowOrderFullInfoCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        public ShowOrderFullInfoCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
        public override void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public override bool CanExecute(object? parameter)
        {
            return _navigationStore.CurrentViewModel is OrderListViewModel;
        }
    }
}
