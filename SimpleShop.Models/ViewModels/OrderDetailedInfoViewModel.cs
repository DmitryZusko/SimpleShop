using SimpleShop.Models.Services;
using SimpleShop.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.ViewModels
{
    public class OrderDetailedInfoViewModel : ViewModelBase
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

        private string _seller;

        public string Seller
        {
            get { return _seller; }
            set
            {
                _seller = value;
                OnPropertyChanged(nameof(_seller));
            }
        }

        private string _customer;

        public string Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                OnPropertyChanged(nameof(_customer));
            }
        }

        public OrderDetailedInfoViewModel(NavigationService navigationService) : base(navigationService)
        {

        }
    }
}
