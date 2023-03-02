namespace SimpleShop.Models.Models
{
    public interface IGeneralLedger
    {
        public void AddCustomer(Customer newCustomer);
        public void AddOrder(Order newOrder);
        public void AddSeller(Seller newSeller);
        public void DeleteCustomer(int id);
        public void DeleteOrder(int id);
        public void DeleteSeller(int id);
        public int GetCustomerCount(int id);
        public List<Customer> GetCustomersList();
        public int GetOrderCount(int id);
        public List<Order> GetOrdersList();
        public int GetSellerCount(int id);
        public List<Seller> GetSellersList();
    }
}