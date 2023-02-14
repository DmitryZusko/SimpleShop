namespace SimpleShop.DataBaseModel.DBContext

{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Options;
    using SimpleShop.DataBaseModel.DTOs;

    public class DatabaseContext : DbContext
    {
        public DbSet<SellerDTO> Sellers { get; set; }
        public DbSet<CustomerDTO> Customers { get; set; }
        public DbSet<OrderDTO> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=;Initial Catalog=SimpleShopDB;Integrated Security=True;Encrypt=false");
        }


    }
}
