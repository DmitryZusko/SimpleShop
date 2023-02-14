using SimpleShop.Models.Commands;
using SimpleShop.Models.Commands.DeleteCommands;
using SimpleShop.Models.Commands.ShowCommands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.DeleteViewModels
{
    public class OrderDeleteViewModel : ViewModelCommandsBase
    {
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

        public ICommand DeleteOrderCommand { get; }
        public ICommand CancelCommand { get; }
        public OrderDeleteViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            DeleteOrderCommand = new DeleteOrderCommand(_navigationService, _simpleShop, ID, CreateOrderListViewModel, this);
            CancelCommand = new ShowOrdersCommand(_navigationService, CreateOrderListViewModel);
        }
    }
}
