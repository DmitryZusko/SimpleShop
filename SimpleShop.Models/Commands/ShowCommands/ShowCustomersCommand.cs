using SimpleShop.Models.Services;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;

namespace SimpleShop.Models.Commands.ShowCommands
{
    public class ShowCustomersCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly Func<ViewModelBase> _createCustomerListViewModel;

        public ShowCustomersCommand(NavigationService navigationStore, Func<ViewModelBase> createCustomerListViewModel)
        {
            _navigationService = navigationStore;
            _createCustomerListViewModel = createCustomerListViewModel;
        }
        public override void Execute(object? parameter)
        {
            _navigationService.CreateViewModel(_createCustomerListViewModel);
        }
    }
}
