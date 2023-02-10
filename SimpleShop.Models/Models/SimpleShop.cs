using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Models
{
    public class SimpleShop
    {
        private readonly GeneralLedger _generalLedger = new GeneralLedger();

        public IEnumerable<Seller> GetSellersList()
        {
            return _generalLedger.GetSellersList();
        }

        public IEnumerable<Customer> GetCustomersList()
        {
            return _generalLedger.GetCustomersList();
        }

        public IEnumerable<Order> GetOrdersList()
        {
            return _generalLedger.GetOrdersList();
        }

        public void AddSeller(Seller newSeller)
        {
            _generalLedger.AddSeller(newSeller);
        }

        public void AddCustomer(Customer newcustomer)
        {
            _generalLedger.AddCustomer(newcustomer);
        }

        public void AddOrder(Order neworder)
        {
            _generalLedger.AddOrder(neworder);
        }
    }
}
