namespace SimpleShop.Models.ViewModels.ClassViewModels
{
    public class FullOrderViewModel : ViewModelBase
    {
        private string _id;

        public string ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(_id));
            }
        }

        private string _orderDate;

        public string OrderDate
        {
            get { return _orderDate; }
            set
            {
                _orderDate = value;
                OnPropertyChanged(nameof(_orderDate));
            }
        }

        private string _amount;

        public string Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(_amount));
            }
        }

        private string _sellerId;

        public string SellerID
        {
            get { return _sellerId; }
            set
            {
                _sellerId = value;
                OnPropertyChanged(nameof(_sellerId));
            }
        }

        private string _sellerFullName;

        public string SellerFullName
        {
            get { return _sellerFullName; }
            set
            {
                _sellerFullName = value;
                OnPropertyChanged(nameof(_sellerFullName));
            }
        }

        private string _customerId;

        public string CustomerID
        {
            get { return _customerId; }
            set
            {
                _customerId = value;
                OnPropertyChanged(nameof(_customerId));
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

    }
}
