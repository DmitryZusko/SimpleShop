using AutoMapper;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Mappers
{
    public class QueryableMapper
    {
        public MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateProjection<Seller, SellerDTO>();
            cfg.CreateProjection<SellerDTO, Seller>();
            cfg.CreateProjection<Customer, CustomerDTO>();
            cfg.CreateProjection<CustomerDTO, Customer>();
            cfg.CreateProjection<Order, OrderDTO>();
            cfg.CreateProjection<OrderDTO, Order>();
        });
    }
}
