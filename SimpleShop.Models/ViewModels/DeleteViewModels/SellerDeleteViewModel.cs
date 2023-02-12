using SimpleShop.Models.Commands;
using SimpleShop.Models.Commands.DeleteCommands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.Navigation;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.DeleteViewModels
{
    public class SellerDeleteViewModel : ViewModelCommandsBase
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

        public ICommand CancelCommand { get; }
        public ICommand DeleteSellerCommand { get; }
        public SellerDeleteViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            DeleteSellerCommand = new DeleteSellerCommand(_navigationService, _simpleShop, ID, CreateSellerListViewModel, this);
            CancelCommand = new CancelCommand(_navigationService);
        }
    }
}
