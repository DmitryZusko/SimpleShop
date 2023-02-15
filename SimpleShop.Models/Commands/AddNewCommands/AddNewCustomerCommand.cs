namespace SimpleShop.Models.Commands.AddNewCommands
{
    using SimpleShop.Models.Services.Navigation;
    using SimpleShop.Models.ViewModels;
    /// <summary>
    /// Command that allows to create a new instance of <c>SingleCustomerViewModel</c> view model
    /// </summary>
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
