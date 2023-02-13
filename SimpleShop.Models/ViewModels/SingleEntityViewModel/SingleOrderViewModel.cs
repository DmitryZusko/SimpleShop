using SimpleShop.Models.Commands.ConfirmCommands;
using SimpleShop.Models.Commands.ShowCommands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.Navigation;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.SingleEntityViewModel
{
    public class SingleOrderViewModel : ViewModelCommandsBase
    {
        private decimal _amount;

        public decimal Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(_amount));
            }
        }

        private int _sellerID;

        public int SellerID
        {
            get { return _sellerID; }
            set
            {
                _sellerID = value;
                OnPropertyChanged(nameof(_sellerID));
            }
        }

        private int _customerID;

        public int CustomerID
        {
            get { return _customerID; }
            set
            {
                _customerID = value;
                OnPropertyChanged(nameof(_customerID));
            }
        }





        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
        public SingleOrderViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            SubmitCommand = new ConfirmNewOrderCommand(_navigationService, _simpleShop, new List<string> {Amount.ToString("#.###"), SellerID.ToString(), CustomerID.ToString()}, CreateOrderListViewModel, this);
            CancelCommand = new ShowOrdersCommand(_navigationService, CreateOrderListViewModel);
        }
    }
}