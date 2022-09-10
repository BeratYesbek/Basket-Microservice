namespace WebAPI.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int ExternalUserId { get; set; }
        public string? Username { get; set; }
        public int ProductId{ get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Product? Product { get; set; }
    }
}
