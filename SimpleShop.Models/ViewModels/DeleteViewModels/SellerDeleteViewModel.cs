namespace SimpleShop.Models.ViewModels.DeleteViewModels
{
    using SimpleShop.Models.Commands.DeleteCommands;
    using SimpleShop.Models.Commands.ShowCommands;
    using SimpleShop.Models.Models;
    using SimpleShop.Models.Services.MVMServices.MVMRemovers;
    using SimpleShop.Models.Services.Navigation;
    using System.Windows.Input;
    public class SellerDeleteViewModel : ViewModelCommandsBase
    {
        private readonly SellerMVMRemover _sellerRemover;

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
        public SellerDeleteViewModel(NavigationService navigationService, ISimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _sellerRemover = new SellerMVMRemover(_simpleShop);

            DeleteSellerCommand = new DeleteSellerCommand(_navigationService, _sellerRemover, ID, CreateSellerListViewModel, this);
            CancelCommand = new ShowSellersCommand(_navigationService, CreateSellerListViewModel);
        }
    }
}
