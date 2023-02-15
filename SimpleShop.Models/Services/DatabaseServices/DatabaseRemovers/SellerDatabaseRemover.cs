namespace SimpleShop.Models.Services.DatabaseServices.DatabaseRemovers
{
    using SimpleShop.DataBaseModel.DBContext;
    using SimpleShop.DataBaseModel.DTOs;
    using SimpleShop.Models.Models;
    /// <summary>
    /// Allows to connect DataBase and remove certain seller from related table.
    /// </summary>
    public class SellerDatabaseRemover : DatabaseServiceBase
    {
        public void Remove(Seller seller)
        {
            using (var context = new DatabaseContext())
            {
                context.Sellers.Remove(Map<Seller, SellerDTO>(seller));
                context.SaveChanges();
            }
        }
    }
}
