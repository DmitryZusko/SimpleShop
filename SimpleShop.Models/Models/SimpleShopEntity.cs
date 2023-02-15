namespace SimpleShop.Models.Models
{
    /// <summary>
    /// Main outer model, that should incapsulate all inner logic from view models.
    /// </summary>
    public class SimpleShopEntity
    {
        private readonly GeneralLedger _generalLedger;
        public SimpleShopEntity()
        {
            _generalLedger = new GeneralLedger();
        }

        public List<Seller> GetSellersList()
        {
            return _generalLedger.GetSellersList();
        }

        public List<Customer> GetCustomersList()
        {
            return _generalLedger.GetCustomersList();
        }

        public List<Order> GetOrdersList()
        {
            return _generalLedger.GetOrdersList();
        }

        public void AddSeller(Seller newSeller)
        {
            _generalLedger.AddSeller(newSeller);
        }

        public void AddCustomer(Customer newCustomer)
        {
            _generalLedger.AddCustomer(newCustomer);
        }

        public void AddOrder(Order newOrder)
        {
            _generalLedger.AddOrder(newOrder);
        }

        public void DeleteSeller(int id)
        {
            _generalLedger.DeleteSeller(id);
        }

        public void DeleteCustomer(int id)
        {
            _generalLedger.DeleteCustomer(id);
        }

        public void DeleteOrder(int id)
        {
            _generalLedger.DeleteOrder(id);
        }
    }
}
