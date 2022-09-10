using System.Drawing;

namespace WebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int ExternalId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int ColorId { get; set; }
        public string? ColorName { get; set; }
        public List<string>? Images { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
