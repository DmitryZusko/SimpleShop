namespace SimpleShop.Models.Models
{
    public interface ISimpleShopEntity
    {
        void AddCustomer(Customer newCustomer);
        void AddOrder(Order newOrder);
        void AddSeller(Seller newSeller);
        void DeleteCustomer(int id);
        void DeleteOrder(int id);
        void DeleteSeller(int id);
        int GetCustomerCount(int id);
        List<Customer> GetCustomersList();
        int GetOrderCount(int id);
        List<Order> GetOrdersList();
        int GetSellerCount(int id);
        List<Seller> GetSellersList();
    }
}