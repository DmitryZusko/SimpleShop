using SimpleShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Stores
{
    public class NavigationStore
    {
		private ViewModelBase _currentviewModel;
		private ViewModelBase _previousViewModel;

		public ViewModelBase CurrentViewModel
		{
			get { return _currentviewModel; }
			set 
			{
				_previousViewModel = _currentviewModel;
				_currentviewModel = value; 
				OnCurrentViewModelChanged();
			}
		}

		public event Action CurrentViewModelChanged;
		
		private void OnCurrentViewModelChanged()
		{
			CurrentViewModelChanged?.Invoke();
		}

		public void ReturnToPreviousViewModel()
		{
			if (_previousViewModel == null)
			{
				return;
			}
            CurrentViewModel = _previousViewModel;
		}
	}
}
