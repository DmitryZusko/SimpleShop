using SimpleShop.Models.Commands;
using SimpleShop.Models.Stores;
using System.Windows.Input;

namespace SimpleShop.Models.ViewModels
{
    public class CustomerViewModel : ViewModelBase
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

        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set
            {
                _companyName = value;
                OnPropertyChanged(nameof(_companyName));
            }
        }

        public ICommand SubmitCommand { get;}
        public ICommand CancelCommand { get;}

        private readonly NavigationStore _navigationStore;

        public CustomerViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            CancelCommand = new CancelCommand(_navigationStore);
        }
    }
}