namespace SimpleShop.Models.ViewModels.DeleteViewModels
{
    using SimpleShop.Models.Commands.DeleteCommands;
    using SimpleShop.Models.Commands.ShowCommands;
    using SimpleShop.Models.Models;
    using SimpleShop.Models.Services.MVMServices.MVMRemovers;
    using SimpleShop.Models.Services.Navigation;
    using System.Windows.Input;
    public class OrderDeleteViewModel : ViewModelCommandsBase
    {
        private readonly OrderMVMRemover _orderRemover;

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

        public ICommand DeleteOrderCommand { get; }
        public ICommand CancelCommand { get; }
        public OrderDeleteViewModel(NavigationService navigationService, SimpleShopEntity simpleShop) : base(navigationService, simpleShop)
        {
            _orderRemover = new OrderMVMRemover(_simpleShop);

            DeleteOrderCommand = new DeleteOrderCommand(_navigationService, _orderRemover, ID, CreateOrderListViewModel, this);
            CancelCommand = new ShowOrdersCommand(_navigationService, CreateOrderListViewModel);
        }
    }
}
