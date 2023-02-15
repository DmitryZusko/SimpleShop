using SimpleShop.Models.Services.DatabaseServices.DatabaseCreators;
using SimpleShop.Models.Services.DatabaseServices.DatabaseProviders;
using SimpleShop.Models.Services.DatabaseServices.DatabaseRemovers;

namespace SimpleShop.Models.Models
{
    public class GeneralLedger
    {
        private List<Seller> _sellers;
        private List<Customer> _customers;
        private List<Order> _orders;
        private readonly SellersDatabaseProvider _sellerProvider;
        private readonly CustomerDatabaseProvider _customersProvider;
        private readonly OrderDatabaseProvider _ordersProvider;
        private readonly SellerDatabaseCreator _sellerCreator;
        private readonly CustomerDatabaseCreator _customerCreator;
        private readonly OrderDatabaseCreator _orderCreator;
        private readonly SellerDatabaseRemover _sellerRemover;
        private readonly CustomerDatabaseRemover _customerRemover;
        private readonly OrderDatabaseRemover _orderRemover;

        public GeneralLedger()
        {
            _sellerProvider = new SellersDatabaseProvider();
            _customersProvider = new CustomerDatabaseProvider();
            _ordersProvider = new OrderDatabaseProvider();
            _sellerCreator = new SellerDatabaseCreator();
            _customerCreator = new CustomerDatabaseCreator();
            _orderCreator = new OrderDatabaseCreator();
            _sellerRemover = new SellerDatabaseRemover();
            _customerRemover = new CustomerDatabaseRemover();
            _orderRemover = new OrderDatabaseRemover();

            _sellers = _sellerProvider.LoadTable();
            _customers = _customersProvider.LoadTable();
            _orders = _ordersProvider.LoadTable();
        }

        public List<Seller> GetSellersList()
        {
            return _sellers;
        }

        public List<Customer> GetCustomersList()
        {
            return _customers;
        }

        public List<Order> GetOrdersList()
        {
            return _orders;
        }

        public void AddSeller(Seller newSeller)
        {
            _sellers.Add(_sellerCreator.AddNew(newSeller));
        }

        public void AddCustomer(Customer newCustomer)
        {
            _customers.Add(_customerCreator.AddNew(newCustomer));
        }

        public void AddOrder(Order newOrder)
        {
            _orders.Add(_orderCreator.AddNew(newOrder));
        }

        public void DeleteSeller(int id)
        {
            _sellerRemover.Remove(_sellerProvider.GetSeller(id));
            _sellers.Remove(_sellers.FirstOrDefault(s => s.ID == id));
        }

        public void DeleteCustomer(int id)
        {
            _customerRemover.Remove(_customersProvider.GetCustomer(id));
            _customers.Remove(_customers.FirstOrDefault(c => c.ID == id));
        }
        public void DeleteOrder(int id)
        {
            _orderRemover.Remove(_ordersProvider.GetOrder(id));
            _orders.Remove(_orders.FirstOrDefault(o => o.ID == id));
        }

    }
}