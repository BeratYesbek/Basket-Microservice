namespace WebAPI.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int ExternalUserId { get; set; }
        public int ProductId{ get; set; }
        public Product? Product { get; set; }
    }
}
