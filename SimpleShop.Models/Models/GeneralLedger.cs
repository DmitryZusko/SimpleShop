using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Services.DatabaseServices.DatabaseCreators;
using SimpleShop.Models.Services.DatabaseServices.DatabaseProviders;
using SimpleShop.Models.Services.DatabaseServices.DatabaseRemovers;
using SimpleShop.Models.Services.ModelViewModelConverter;
using SimpleShop.Models.Services.Validatiors;

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
        private readonly MVVMConverter _mvvmConverter;
        private readonly IdentificatorValidator _idValidatior;

        public GeneralLedger()
        {
            _sellerProvider = new SellersDatabaseProvider();
            _customersProvider = new CustomerDatabaseProvider();
            _ordersProvider = new OrderDatabaseProvider();
            _sellerCreator = new SellerDatabaseCreator();
            _customerCreator = new CustomerDatabaseCreator();
            _orderCreator = new OrderDatabaseCreator();
            _mvvmConverter = new MVVMConverter();
            _idValidatior = new IdentificatorValidator();
            _sellerRemover = new SellerDatabaseRemover();
            _customerRemover = new CustomerDatabaseRemover();
            _orderRemover= new OrderDatabaseRemover();

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
            var newSeller = _sellerCreator.AddNew(_mvvmConverter.Map<SellerDTO>(new Seller { FullName = newSellerName }));
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
                    UtcNow,
                    Amount = amount,
                    SellerId = sellerID,
                    CustomerId = customerID
                }));
            _orders.Add(_mvvmConverter.Map<Order>(newOrder));
        }

        public void DeleteSeller(int id)
        {
            if (_idValidatior.Validate(id, this, IdentificatorValidator.ValidationMode.seller))
            {
                _sellerRemover.Remove(_sellerProvider.GetSeller(id));
                _sellers.Remove(_sellers.FirstOrDefault(s => s.ID == id));
            }
        }

        public void DeleteCustomer(int id)
        {
            if (_idValidatior.Validate(id, this, IdentificatorValidator.ValidationMode.customer))
            {
                _customerRemover.Remove(_customersProvider.GetCustomer(id));
                _customers.Remove(_customers.FirstOrDefault(c => c.ID == id));
            }
        }
        public void DeleteOrder(int id)
        {
            if (_idValidatior.Validate(id, this, IdentificatorValidator.ValidationMode.order))
            {
                _orderRemover.Remove(_ordersProvider.GetOrder(id));
                _orders.Remove(_orders.FirstOrDefault(o => o.ID == id));
            }
        }

    }
}