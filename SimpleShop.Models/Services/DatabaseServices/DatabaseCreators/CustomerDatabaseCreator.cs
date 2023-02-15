namespace SimpleShop.Models.Services.DatabaseServices.DatabaseCreators
{
    using AutoMapper.QueryableExtensions;
    using SimpleShop.DataBaseModel.DBContext;
    using SimpleShop.DataBaseModel.DTOs;
    using SimpleShop.Models.Models;

    public class CustomerDatabaseCreator : DatabaseServiceBase
    {
        /// <summary>
        /// Allows to connect DataBase and add new <c>CustomerDTO</c> into related table.
        /// </summary>
        /// <returns>
        /// Returns newly added <c>CustomerDTO</c>, mapped to a <c>Customer</c> type.
        /// </returns>
        public Customer AddNew(Customer newCustomer)
        {
            using (var context = new DatabaseContext())
            {
                var newCustomerDTO = Map<Customer, CustomerDTO>(newCustomer);
                context.Customers.Add(newCustomerDTO);
                context.SaveChanges();
                return context.Customers.ProjectTo<Customer>(QuerybleConfig).FirstOrDefault(c => c.ID == newCustomerDTO.ID);
            }
        }
    }
}
