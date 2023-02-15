namespace SimpleShop.Models.ViewModels.SingleEntityViewModel
{
    using SimpleShop.Models.Commands.ConfirmCommands;
    using SimpleShop.Models.Commands.ShowCommands;
    using SimpleShop.Models.Models;
    using SimpleShop.Models.Services.MVMServices.MVMCreators;
    using SimpleShop.Models.Services.Navigation;
    using System.Windows.Input;

    /// <summary>
    /// ViewModel for a <c>AddNewCustomerViewControl</c> View.
    /// </summary>
    public class SingleCustomerViewModel : ViewModelCommandsBase
    {
        private readonly CustomerMVMCreator _customerCreator;

        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set
            {
                _companyName = value;
                OnPropertyChanged(nameof(_companyName));
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public SingleCustomerViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _customerCreator = new CustomerMVMCreator(_simpleShop);

            SubmitCommand = new ConfirmNewCustomerCommand(navigationService, _customerCreator, CompanyName, CreateCustomerListViewModel, this);
            CancelCommand = new ShowCustomersCommand(_navigationService, CreateCustomerListViewModel); ;
        }
    }
}