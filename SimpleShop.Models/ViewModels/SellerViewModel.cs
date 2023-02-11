using SimpleShop.Models.Commands;
using SimpleShop.Models.Models;
using SimpleShop.Models.Stores;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels
{
    public class SellerViewModel : ViewModelBase
    {

        private Seller _seller;
        private string _firstName => _seller.FirstName;
        private string _lastName => _seller.LastName;

        public int ID { get; }

        public string FullName => $"{_firstName} {_lastName}";
        private readonly NavigationStore _navigationStore;
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public SellerViewModel(Seller seller, NavigationStore navigationStore)
        {
            _seller = seller;
            _navigationStore = navigationStore;
            CancelCommand = new CancelCommand(_navigationStore);
        }
    }
}
