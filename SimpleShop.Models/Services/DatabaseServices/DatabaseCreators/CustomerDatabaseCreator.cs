using AutoMapper.QueryableExtensions;
using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.DatabaseServices.DatabaseCreators
{
    public class CustomerDatabaseCreator : DatabaseServiceBase
    {
        public Customer AddNew(Customer newCustomer)
        {
            using (var context = new DatabaseContext())
            {
                var newCustomerDTO = Map<Customer, CustomerDTO>(newCustomer);
                context.Customers.Add(newCustomerDTO);
                context.SaveChanges();
                return context.Customers.ProjectTo<Customer>(QuerybleConfig).FirstOrDefault(c => c.ID == newCustomerDTO.ID);
            }
        }
    }
}
