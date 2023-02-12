namespace SimpleShop.Models.ViewModels.ClassViewModels
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
	}
}
