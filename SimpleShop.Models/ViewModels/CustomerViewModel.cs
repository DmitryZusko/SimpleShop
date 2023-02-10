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
    }
}