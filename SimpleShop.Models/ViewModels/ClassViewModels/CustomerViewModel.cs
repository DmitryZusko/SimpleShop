namespace SimpleShop.Models.ViewModels.ClassViewModels
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

		private string _company;

		public string Company
		{
			get { return _company; }
			set 
			{ 
				_company = value; 
				OnPropertyChanged(nameof(_company));
			}
		}


	}
}
