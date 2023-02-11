namespace SimpleShop.Models.Models
{
    public class Order : IModel
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }
        public Seller Seller { get; set; }
        public Customer Customer { get; set; }
    }
}
