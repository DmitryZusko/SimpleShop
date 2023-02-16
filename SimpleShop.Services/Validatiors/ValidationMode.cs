namespace SimpleShop.Models.Services.Validatiors
{
    public partial class IdentificatorValidator
    {
        /// <summary>
        /// Allows to switch between Validator seraching mods:
        /// seller - searching in the db.Seller table;
        /// customer - searching in the db.Customer table;
        /// order - searching in the db.Order table.
        /// </summary>
        public enum ValidationMode
        {
            seller,
            customer,
            order
        }
    }
}
