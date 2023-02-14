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

        public void AddSeller(string newSellerName)
        {
            _generalLedger.AddSeller(newSellerName);
        }

        public void AddCustomer(string newCustomer)
        {
            _generalLedger.AddCustomer(newCustomer);
        }

        public void AddOrder(List<string> orderInfo)
        {
            decimal amount;
            decimal.TryParse(orderInfo[0], out amount);
            int sellerID;
            int.TryParse(orderInfo[1],out sellerID);
            int customerID;
            int.TryParse(orderInfo[2],out customerID);
            _generalLedger.AddOrder(amount, sellerID, customerID);
        }

        internal void DeleteSeller(int id)
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
