namespace WebAPI.Models
{
    public class ShoppingCart
    {
        public int ExternalUserId { get; set; }

        public List<Product>? Products { get; set; }

        public float TotalPrice
        {
            get
            {
                return Products!.Sum(product => product.Price);
            }
        }
    }
}
