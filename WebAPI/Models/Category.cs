namespace WebAPI.Models
{
    public class Category 
    {
        public int Id { get; set; }
        public int ExternalId { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual List<Product>? Products { get; set; }
    }
}
