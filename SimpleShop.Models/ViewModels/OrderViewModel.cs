﻿using SimpleShop.Models.Commands;
using SimpleShop.Models.Stores;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels
{
    public class OrderViewModel : ViewModelBase
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

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
        private readonly NavigationStore _navigationStore;
        public OrderViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            CancelCommand = new CancelCommand(_navigationStore);
        }
    }
}