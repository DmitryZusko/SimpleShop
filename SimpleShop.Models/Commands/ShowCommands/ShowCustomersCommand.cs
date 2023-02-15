namespace SimpleShop.Models.Commands.ShowCommands
{
    using SimpleShop.Models.Services.Navigation;
    using SimpleShop.Models.ViewModels;
    /// <summary>
    /// Command that allows to create new <c>CustomerListViewModel</c> view model
    /// </summary>
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
