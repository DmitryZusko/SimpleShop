using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels.DeleteViewModels;
using SimpleShop.Models.ViewModels.ListViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Commands.DeleteCommands
{
    public class DeleteCustomerCommand : CommandBase
    {
        private NavigationService _navigationService;
        private SimpleShopEntity _simpleShop;
        private int _id;
        private Func<CustomerListViewModel> _createNewView;
        private CustomerDeleteViewModel _parentViewModel;

        public DeleteCustomerCommand(NavigationService navigationService, SimpleShopEntity simpleShop, int iD, Func<CustomerListViewModel> createNewView, CustomerDeleteViewModel parentViewModel)
        {
            _navigationService = navigationService;
            _simpleShop = simpleShop;
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
            _simpleShop.DeleteCustomer(_id);
            _navigationService.CreateViewModel(_createNewView);
        }
    }
}
