using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Models
{
    public class SimpleShopEntity
    {
        private readonly GeneralLedger _generalLedger = new GeneralLedger();

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
