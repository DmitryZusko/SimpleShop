using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Services.DatabaseCreators;
using SimpleShop.Models.Services.DatabaseProviders;
using SimpleShop.Models.Services.ModelViewModelConverter;

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
        private readonly SellerCreator _sellerCreator;
        private readonly CustomerCreator _customerCreator;
        private readonly OrderCreator _orderCreator;
        private readonly MVVMConverter _mvvmConverter;

        public GeneralLedger()
        {
            _sellerProvider = new SellersDatabaseProvider();
            _customersProvider = new CustomerDatabaseProvider();
            _ordersProvider = new OrderDatabaseProvider();
            _sellerCreator = new SellerCreator();
            _customerCreator = new CustomerCreator();
            _orderCreator = new OrderCreator();
            _mvvmConverter = new MVVMConverter();
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

        public void AddSeller(string newSellerName)
        {
            var newSeller = _sellerCreator.AddNew(_mvvmConverter.Map<SellerDTO>(new Seller { FullName = newSellerName}));
            _sellers.Add(_mvvmConverter.Map<Seller>(newSeller));
        }

        public void AddCustomer(string newCustomerCompany)
        {
            var newCustomer = _customerCreator.AddNew(_mvvmConverter.Map<CustomerDTO>(new Customer { Company = newCustomerCompany }));
            _customers.Add(_mvvmConverter.Map<Customer>(newCustomer));
        }

        public void AddOrder(decimal amount, int sellerID, int customerID)
        {
            var newOrder = _orderCreator
                .AddNew(_mvvmConverter
                .Map<OrderDTO>(new Order 
                { 
                    OrderDate = DateTime.
                    UtcNow, Amount = amount, 
                    SellerId = sellerID, 
                    CustomerId = customerID 
                }));
            _orders.Add(_mvvmConverter.Map<Order>(newOrder));
        }
    }
}