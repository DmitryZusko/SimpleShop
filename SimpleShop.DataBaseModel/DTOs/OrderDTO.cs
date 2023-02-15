namespace SimpleShop.DataBaseModel.DTOs
{
    using System.ComponentModel.DataAnnotations.Schema;
    public class OrderDTO
    {
        public int ID { get; set; }
        [Column(TypeName = "SMALLDATETIME ")]
        public DateTime OrderDate { get; set; }
        [Column(TypeName = "decimal(16,3)")]
        public decimal Amount { get; set; }
        public int SellerID { get; set; }
        public SellerDTO Seller { get; set; }
        public int CustomerID { get; set; }
        public CustomerDTO Customer { get; set; }
    }
}
