namespace SimpleShop.Models.Commands.DeleteCommands
{
    using SimpleShop.Models.Services.Navigation;
    using SimpleShop.Models.ViewModels;
    /// <summary>
    /// Command that allows to create new <c>CustomerDeleteViewModel</c> view model
    /// </summary>
    public class OpenCustomerDeleteMenuCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly Func<ViewModelBase> _createNewViewModel;

        public OpenCustomerDeleteMenuCommand(NavigationService navigationService, Func<ViewModelBase> createNewViewModel)
        {
            _navigationService = navigationService;
            _createNewViewModel = createNewViewModel;
        }
        public override void Execute(object? parameter)
        {
            _navigationService.CreateViewModel(_createNewViewModel);
        }
    }
}
