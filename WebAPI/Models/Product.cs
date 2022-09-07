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
        public int ColorId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Category? Category { get; set; }
        public Color? Color { get; set; }
        public virtual List<ProductImage>? ProductImages { get; set; }

    }
}
