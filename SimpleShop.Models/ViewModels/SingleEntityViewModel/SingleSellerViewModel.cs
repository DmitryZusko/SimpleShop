namespace SimpleShop.Models.ViewModels.SingleEntityViewModel
{
    using SimpleShop.Models.Commands.ConfirmCommands;
    using SimpleShop.Models.Commands.ShowCommands;
    using SimpleShop.Models.Models;
    using SimpleShop.Models.Services.MVMServices.MVMCreators;
    using SimpleShop.Models.Services.Navigation;
    using System.Windows.Input;
    /// <summary>
    /// ViewModel for a <c>AddNewSellerViewControl</c> View.
    /// </summary>
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

        public SingleSellerViewModel(NavigationService navigationService, ISimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _sellerCreator = new SellerMVMCreator(_simpleShop);

            CancelCommand = new ShowSellersCommand(_navigationService, CreateSellerListViewModel);
            SubmitCommand = new ConfirmNewSellerCommand(_navigationService, _sellerCreator, FullName, CreateSellerListViewModel, this);
        }
    }
}
