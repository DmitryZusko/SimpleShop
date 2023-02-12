using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels.ListViewModels;

namespace SimpleShop.Models.Commands.ShowCommands
{
    public class ShowOrderFullInfoCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly Func<OrderFullInfoViewModel> _newViewModel;

        public ShowOrderFullInfoCommand(NavigationService navigationService, Func<OrderFullInfoViewModel> newViewModel)
        {
            _navigationService = navigationService;
            _newViewModel = newViewModel;
        }
        public override void Execute(object? parameter)
        {
            _navigationService.CreateViewModel(_newViewModel);
        }
    }
}
