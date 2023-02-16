namespace SimpleShop.Models.Services.DatabaseServices.DatabaseCreators
{
    using AutoMapper.QueryableExtensions;
    using SimpleShop.DataBaseModel.DBContext;
    using SimpleShop.DataBaseModel.DTOs;
    using SimpleShop.Models.Models;

    public class SellerDatabaseCreator : DatabaseServiceBase
    {
        /// <summary>
        /// Allows to connect DataBase and add new <c>SellerDTO</c> into related table.
        /// </summary>
        /// <returns>
        /// Returns newly added <c>SellerDTO</c>, mapped to a <c>Seller</c> type.
        /// </returns>
        public Seller AddNew(Seller newSeller)
        {
            using (var context = new DatabaseContext())
            {
                var newSellerDTO = Map<Seller, SellerDTO>(newSeller);
                context.Sellers.Add(newSellerDTO);
                context.SaveChanges();
                return context.Sellers.ProjectTo<Seller>(QuerybleConfig).FirstOrDefault(s => s.ID == newSellerDTO.ID);
            }
        }
    }
}
