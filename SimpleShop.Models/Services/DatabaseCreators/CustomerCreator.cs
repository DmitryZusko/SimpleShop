using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.DatabaseCreators
{
    public class CustomerCreator
    {
        public CustomerDTO AddNew(CustomerDTO newCustomer)
        {
            using (var context = new DatabaseContext())
            {
                context.Customers.Add(newCustomer);
                context.SaveChanges();
                return newCustomer;
            }
        }
    }
}
