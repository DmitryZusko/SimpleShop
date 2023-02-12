using SimpleShop.Models.Services;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;

namespace SimpleShop.Models.Commands.AddNewCommands
{
    internal class AddNewOrderCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly Func<ViewModelBase> _createOrderViewModel;

        public AddNewOrderCommand(NavigationService navigationService, Func<ViewModelBase> createOrderViewModel)
        {
            _navigationService = navigationService;
            _createOrderViewModel = createOrderViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.CreateViewModel(_createOrderViewModel);
        }
    }
}
