using SimpleShop.Models.Services;
using SimpleShop.Models.ViewModels;
using SimpleShop.Models.ViewModels.ClassViewModels;

namespace SimpleShop.Models.Commands
{
    public class UpdateCustomerCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly Func<ViewModelBase, ViewModelBase> _customerViewModel;
        private readonly CustomerViewModel _customertoUpdate;

        public UpdateCustomerCommand(NavigationService navigationStore, CustomerViewModel customertoUpdate, Func<ViewModelBase, ViewModelBase> customerViewModel)
        {
            _navigationService = navigationStore;
            _customerViewModel = customerViewModel;
            _customertoUpdate = customertoUpdate;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.CreateBindedViewModel(_customerViewModel, _customertoUpdate);
        }
    }
}
