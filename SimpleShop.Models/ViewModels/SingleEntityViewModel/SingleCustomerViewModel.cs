using SimpleShop.Models.Commands;
using SimpleShop.Models.Commands.AddNewCommands;
using SimpleShop.Models.Commands.ConfirmCommands;
using SimpleShop.Models.Commands.ShowCommands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels.ListViewModels;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.SingleEntityViewModel
{
    public class SingleCustomerViewModel : ViewModelCommandsBase
    {
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
            SubmitCommand = new ConfirmNewCustomerCommand(navigationService, simpleShop, CompanyName, CreateCustomerListViewModel, this);
            CancelCommand = new ShowCustomersCommand(_navigationService, CreateCustomerListViewModel); ;
        }
    }
}