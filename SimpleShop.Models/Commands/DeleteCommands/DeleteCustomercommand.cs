namespace SimpleShop.Models.Commands.DeleteCommands
{
    using SimpleShop.Models.Services.MVMServices.MVMRemovers;
    using SimpleShop.Models.Services.Navigation;
    using SimpleShop.Models.ViewModels.DeleteViewModels;
    using SimpleShop.Models.ViewModels.ListViewModels;
    using System.ComponentModel;
    /// <summary>
    /// Command that allows to delete Customer
    /// </summary>
    public class DeleteCustomerCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly CustomerMVMRemover _customerRemover;
        private readonly Func<CustomerListViewModel> _createNewView;
        private readonly CustomerDeleteViewModel _parentViewModel;
        private int _id;

        public DeleteCustomerCommand(NavigationService navigationService, CustomerMVMRemover customerRemover, int iD, Func<CustomerListViewModel> createNewView, CustomerDeleteViewModel parentViewModel)
        {
            _navigationService = navigationService;
            _customerRemover = customerRemover;
            _id = iD;
            _createNewView = createNewView;
            _parentViewModel = parentViewModel;
            _parentViewModel.PropertyChanged += _parentViewModel_PropertyChanged;
        }

        private void _parentViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            _id = _parentViewModel.ID;
        }

        public override void Execute(object? parameter)
        {
            _customerRemover.Remove(_id);
            _navigationService.CreateViewModel(_createNewView);
        }
    }
}
