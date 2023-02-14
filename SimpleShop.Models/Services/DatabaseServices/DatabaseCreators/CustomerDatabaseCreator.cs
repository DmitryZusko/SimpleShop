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
        public CustomerDTO AddNew(Customer newCustomer)
        {
            using (var context = new DatabaseContext())
            {
                
            }
        }
    }
}
