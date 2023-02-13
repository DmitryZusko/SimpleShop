using AutoMapper.QueryableExtensions;
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
    internal class OrderDatabaseRemover : MVVMConverter
    {
        public void Remove(Order order)
        {
            using (var context = new DatabaseContext())
            {
                context.Orders.Remove(Map<OrderDTO>(order));
                context.SaveChanges();
            }
        }
    }
}
