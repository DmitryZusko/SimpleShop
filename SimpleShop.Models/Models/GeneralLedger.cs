using SimpleShop.Models.Services.DatabaseProviders;

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

        public GeneralLedger()
        {
            //_sellerProvider = new SellersDatabaseProvider();
            //_customersProvider = new CustomerDatabaseProvider();
            //_ordersProvider = new OrderDatabaseProvider();
            //_sellers = _sellerProvider.LoadTable();
            //_customers = _customersProvider.LoadTable();
            //_orders = _ordersProvider.LoadTable();
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
            _sellers.Add(newSeller);
        }

        public void AddCustomer(Customer newcustomer)
        {
            _customers.Add(newcustomer);
        }

        public void AddOrder(Order neworder)
        {
            _orders.Add(neworder);
        }
    }
}