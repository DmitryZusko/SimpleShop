﻿namespace SimpleShop.Models.Models
{
    public class Order : IModel
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }
        public int SellerId { get; set; }
        public string SellerFullName { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCompany { get; set; }
    }
}
