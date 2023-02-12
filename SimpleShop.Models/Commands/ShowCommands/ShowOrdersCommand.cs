using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;

namespace SimpleShop.Models.Commands.ShowCommands
{
    public class ShowOrdersCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly Func<ViewModelBase> _createOrderListViewModel;

        public ShowOrdersCommand(NavigationService navigationService, Func<ViewModelBase> createOrderListViewModel)
        {
            _navigationService = navigationService;
            _createOrderListViewModel = createOrderListViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.CreateViewModel(_createOrderListViewModel);
        }
    }
}
