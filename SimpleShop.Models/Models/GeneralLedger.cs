namespace SimpleShop.Models.Models
{
    public class GeneralLedger
    {
        private List<Seller> _sellers;
        private List<Customer> _customers;
        private List<Order> _orders;

        public GeneralLedger()
        {
            _sellers = new List<Seller>();
            _customers = new List<Customer>();
            _orders = new List<Order>();
        }

        public IEnumerable<Seller> GetSellersList()
        {
            return _sellers;
        }

        public IEnumerable<Customer> GetCustomersList()
        {
            return _customers;
        }

        public IEnumerable<Order> GetOrdersList()
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