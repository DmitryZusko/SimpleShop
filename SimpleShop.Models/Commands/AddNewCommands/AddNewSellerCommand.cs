namespace SimpleShop.Models.Commands.AddNewCommands
{
    using SimpleShop.Models.Services.Navigation;
    using SimpleShop.Models.ViewModels;
    /// <summary>
    /// Command that allows to create a new instance of <c>SingleCustomerViewModel</c> view model
    /// </summary>
    public class AddNewSellerCommand : CommandBase
    {
        private NavigationService _navigationService;
        private Func<ViewModelBase> _sellerViewModel;

        public AddNewSellerCommand(NavigationService navigationService, Func<ViewModelBase> sellerViewModel)
        {
            _navigationService = navigationService;
            _sellerViewModel = sellerViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.CreateViewModel(_sellerViewModel);
        }
    }
}
