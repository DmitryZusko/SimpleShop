using SimpleShop.Models.Services;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels;

namespace SimpleShop.Models.Commands
{
    public class AddNewCustomerCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly Func<ViewModelBase> _customerViewModel;

        public AddNewCustomerCommand(NavigationService navigationStore, Func<ViewModelBase> customerViewModel)
        {
            _navigationService = navigationStore;
            _customerViewModel = customerViewModel;
        }
        public override void Execute(object? parameter)
        {
            _navigationService.CreateViewModel(_customerViewModel);
        }
    }
}
