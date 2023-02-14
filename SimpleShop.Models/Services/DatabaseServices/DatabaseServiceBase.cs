using AutoMapper;
using SimpleShop.DataBaseModel.DTOs;
using SimpleShop.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models.Services.DatabaseServices
{
    public abstract class DatabaseServiceBase : IDatabaseService
    {
        public MapperConfiguration QuerybleConfig
        {
            get
            {
                return new MapperConfiguration(cfg =>
                {
                    cfg.CreateProjection<SellerDTO, Seller>();
                    cfg.CreateProjection<Seller, SellerDTO>();
                    cfg.CreateProjection<CustomerDTO, Customer>();
                    cfg.CreateProjection<Customer, CustomerDTO>();
                    cfg.CreateProjection<OrderDTO, Order>().
                    ForMember(order => order.SellerFullName, cfg => cfg.MapFrom(dto => dto.Seller.FullName)).
                    ForMember(order => order.CustomerCompany, cfg => cfg.MapFrom(dto => dto.Customer.Company));
                    cfg.CreateProjection<Order, OrderDTO>();
                });
            }
        }
    }
}
