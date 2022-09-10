using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;
using WebAPI.Models;
using WebAPI.Repositories.Abstracts;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartsController : ControllerBase
    {
        private readonly IShoppingCartRepository _cartRepository;
        private readonly IMapper _mapper;

        public ShoppingCartsController(IShoppingCartRepository cartRepository,IMapper mapper)
        {
            _cartRepository = cartRepository;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Add(CreateShoppingCartDto cartDto)
        {
            var value = _mapper.Map<ShoppingCart>(cartDto);
            await _cartRepository.CreateAsync(value);
            return Ok(value);
        }

        [HttpGet("/{username}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetByUsername(string username)
        {
            var data = await _cartRepository.GetByUsernameAsync(username);
            return Ok(data);
        }
    }
}
