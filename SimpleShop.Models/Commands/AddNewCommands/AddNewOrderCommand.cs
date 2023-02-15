namespace SimpleShop.Models.Commands.AddNewCommands
{
    using SimpleShop.Models.Services.Navigation;
    using SimpleShop.Models.ViewModels;
    /// <summary>
    /// Command that allows to create a new instance of <c>SingleOrderViewModel</c> view model
    /// </summary>
    public class AddNewOrderCommand : CommandBase
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
