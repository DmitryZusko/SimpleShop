namespace SimpleShop.Models.Commands.ConfirmCommands
{
    using SimpleShop.Models.Services.MVMServices.MVMCreators;
    using SimpleShop.Models.Services.Navigation;
    using SimpleShop.Models.ViewModels;
    using SimpleShop.Models.ViewModels.ClassViewModels;
    using SimpleShop.Models.ViewModels.SingleEntityViewModel;
    /// <summary>
    /// Command that allows to add new Customer
    /// </summary>
    public class ConfirmNewCustomerCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly CustomerMVMCreator _customerCreator;
        private readonly Func<ViewModelBase> _createCustomerListViewModel;
        private readonly SingleCustomerViewModel _parentViewModel;
        private string _company;

        public ConfirmNewCustomerCommand(NavigationService navigationService, CustomerMVMCreator customerCreator, string company, Func<ViewModelBase> createCustomerListViewModel, SingleCustomerViewModel parentViewModel)
        {
            _navigationService = navigationService;
            _customerCreator = customerCreator;
            _company = company;
            _createCustomerListViewModel = createCustomerListViewModel;
            _parentViewModel = parentViewModel;
            _parentViewModel.PropertyChanged += _parentViewModel_PropertyChanged;

        }

        public override void Execute(object? parameter)
        {
            _customerCreator.AddNew(new CustomerViewModel { Company = _company });
            _navigationService.CreateViewModel(_createCustomerListViewModel);
        }

        private void _parentViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            _company = _parentViewModel.CompanyName;
        }


    }
}
