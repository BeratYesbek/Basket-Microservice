using AutoMapper;
using WebAPI.Dto;
using WebAPI.Models;

namespace WebAPI.Profiles
{
    public class CartItemProfile : Profile
    {
        public CartItemProfile()
        {
            CreateMap<ShoppingCart, CreateShoppingCartDto>().ReverseMap();
        }
    }
}
