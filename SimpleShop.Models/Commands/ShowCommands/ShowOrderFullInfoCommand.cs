namespace SimpleShop.Models.Commands.ShowCommands
{
    using SimpleShop.Models.Services.Navigation;
    using SimpleShop.Models.ViewModels.ListViewModels;
    /// <summary>
    /// Command that allows to create new <c>OrderFullInfoViewModel</c> view model
    /// </summary>
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
