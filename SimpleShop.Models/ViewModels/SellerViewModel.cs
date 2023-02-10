using SimpleShop.Models.Models;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels
{
    public class SellerViewModel : ViewModelBase
    {

        private Seller _seller;

        public int ID { get; }

        public string FullName => $"{_seller.FirstName} {_seller.LastName}";

        public SellerViewModel(Seller seller)
        {
            _seller = seller;
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
    }
}
