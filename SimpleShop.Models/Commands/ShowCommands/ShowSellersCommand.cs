namespace SimpleShop.Models.Commands.ShowCommands
{
    using SimpleShop.Models.Services.Navigation;
    using SimpleShop.Models.ViewModels;
    /// <summary>
    /// Command that allows to create new <c>SellerListViewModel</c> view model
    /// </summary>
    public class ShowSellersCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly Func<ViewModelBase> _createSelerListViewModel;

        public ShowSellersCommand(NavigationService navigationService, Func<ViewModelBase> createSelerListViewModel)
        {
            _navigationService = navigationService;
            _createSelerListViewModel = createSelerListViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.CreateViewModel(_createSelerListViewModel);
        }
    }
}
