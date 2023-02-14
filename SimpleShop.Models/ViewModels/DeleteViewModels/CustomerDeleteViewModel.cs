using SimpleShop.Models.Commands;
using SimpleShop.Models.Commands.DeleteCommands;
using SimpleShop.Models.Commands.ShowCommands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.MVMServices.MVMRemovers;
using SimpleShop.Models.Services.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.DeleteViewModels
{
    public class CustomerDeleteViewModel : ViewModelCommandsBase
    {
        private readonly CustomerMVMRemover _customerRemover;

        private int _id;

        public int ID
        {
            get { return _id; }
            set 
            { 
                _id = value; 
                OnPropertyChanged(nameof(_id));
            }
        }

        public ICommand DeleteCustomerCommand { get; }
        public ICommand CancelCommand { get; }
        public CustomerDeleteViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _customerRemover = new CustomerMVMRemover(_simpleShop);

            DeleteCustomerCommand = new DeleteCustomerCommand(_navigationService, _customerRemover, ID, CreateCustomerListViewModel, this);
            CancelCommand = new ShowCustomersCommand(_navigationService, CreateCustomerListViewModel);
        }
    }
}
