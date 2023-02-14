using Microsoft.EntityFrameworkCore;
using SimpleShop.DataBaseModel.DBContext;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;
using SimpleShop.Models.Services.ModelViewModelConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.DatabaseRemovers
{
    internal class CustomerDatabaseRemover : MVVMConverter
    {
        internal void Remove(Customer customer)
        {
            using(var context = new DatabaseContext())
            {
                context.Customers.Remove(Map<CustomerDTO>(customer));
                context.SaveChanges();
            }
        }
    }
}
