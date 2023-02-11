using SimpleShop.Models.Commands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services;
using SimpleShop.Models.Stores;
using SimpleShop.Models.ViewModels.ListViewModels;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels.SingleEntityViewModel
{
    public class SingleSellerViewModel : ViewModelCommandsBase
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
            CancelCommand = new CancelCommand(_navigationService);
        }
    }
}
