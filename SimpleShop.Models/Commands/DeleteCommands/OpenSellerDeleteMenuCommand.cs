namespace SimpleShop.Models.Commands.DeleteCommands
{
    using SimpleShop.Models.Services.Navigation;
    using SimpleShop.Models.ViewModels;
    /// <summary>
    /// Command that allows to create new <c>SellerDeleteViewModel</c> view model
    /// </summary>
    public class OpenSellerDeleteMenuCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly Func<ViewModelBase> _createNewViewModel;
        public OpenSellerDeleteMenuCommand(NavigationService navigationService, Func<ViewModelBase> createNewViewModel)
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
