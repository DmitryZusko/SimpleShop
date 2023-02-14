using SimpleShop.Models.Commands;
using SimpleShop.Models.Commands.ConfirmCommands;
using SimpleShop.Models.Commands.ShowCommands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.MVMServices.MVMCreators;
using SimpleShop.Models.Services.Navigation;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels.ListViewModels;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.SingleEntityViewModel
{
    public class SingleSellerViewModel : ViewModelCommandsBase
    {
        private readonly SellerMVMCreator _sellerCreator;

        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
            set 
            { 
                _fullName = value; 
                OnPropertyChanged(nameof(_fullName));
            }
        }


        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public SingleSellerViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _sellerCreator = new SellerMVMCreator(_simpleShop);

            CancelCommand = new ShowSellersCommand(_navigationService, CreateSellerListViewModel);
            SubmitCommand = new ConfirmNewSellerCommand(_navigationService, _sellerCreator, FullName, CreateSellerListViewModel, this);
        }
    }
}
