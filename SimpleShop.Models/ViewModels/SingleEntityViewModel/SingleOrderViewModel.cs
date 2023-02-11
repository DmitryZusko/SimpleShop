using SimpleShop.Models.Commands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.SingleEntityViewModel
{
    public class SingleOrderViewModel : ViewModelCommandsBase
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
        private DateTime _orderDate;

        public DateTime OrderDate
        {
            get { return _orderDate; }
            set
            {
                _orderDate = value;
                OnPropertyChanged(nameof(_orderDate));
            }
        }

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

        private string _sellerName;

        public string SellerName
        {
            get { return _sellerName; }
            set
            {
                _sellerName = value;
                OnPropertyChanged(nameof(_sellerName));
            }
        }

        private string _customerCompany;

        public string CustomerCompany
        {
            get { return _customerCompany; }
            set
            {
                _customerCompany = value;
                OnPropertyChanged(nameof(_customerCompany));
            }
        }



        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
        public SingleOrderViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            CancelCommand = new CancelCommand(_navigationService);
        }
    }
}