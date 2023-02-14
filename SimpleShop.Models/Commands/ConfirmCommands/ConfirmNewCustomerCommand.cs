using SimpleShop.Models.Models;
using SimpleShop.Models.Services.MVMServices.MVMCreators;
using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.ViewModels;
using SimpleShop.Models.ViewModels.ClassViewModels;
using SimpleShop.Models.ViewModels.SingleEntityViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Commands.ConfirmCommands
{
    public class ConfirmNewCustomerCommand : CommandBase
    {
        private NavigationService _navigationService;
        private CustomerMVMCreator _customerCreator;
        private string _company;
        private Func<ViewModelBase> _createCustomerListViewModel;
        private SingleCustomerViewModel _parentViewModel;

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
