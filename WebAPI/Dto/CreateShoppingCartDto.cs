using WebAPI.Models;

namespace WebAPI.Dto
{
    public class CreateShoppingCartDto
    {
        public int Id { get; set; }
        public int ExternalUserId { get; set; }
        public string? UserName { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
