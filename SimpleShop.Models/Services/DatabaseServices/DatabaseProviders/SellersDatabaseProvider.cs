namespace SimpleShop.Models.Services.DatabaseServices.DatabaseProviders
{
    using AutoMapper.QueryableExtensions;
    using SimpleShop.DataBaseModel.DBContext;
    using SimpleShop.Models.Models;
    /// <summary>
    /// Allows to connect DataBase and get sellers from related table.
    /// </summary>
    public class SellersDatabaseProvider : DatabaseServiceBase
    {
        public List<Seller> LoadTable()
        {
            using (var context = new DatabaseContext())
            {
                return context.Sellers.ProjectTo<Seller>(QuerybleConfig).ToList();
            }
        }
        public Seller GetSeller(int id)
        {
            using (var context = new DatabaseContext())
            {
                return context.Sellers.ProjectTo<Seller>(QuerybleConfig).FirstOrDefault(s => s.ID == id);
            }
        }
    }
}
