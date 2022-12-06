using Microsoft.AspNetCore.Mvc;
using RockShop.Core.Contracts;
using System.Security.Claims;

namespace RockShop.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService cartService;

        public CartController(ICartService _cartService)
        {
            cartService = _cartService;
        }

        public async Task<IActionResult> AddToCart(int id)
        {
            try
            {
                var accId = User.Claims.FirstOrDefault(a => a.Type == ClaimTypes.NameIdentifier)?.Value;

                await cartService.AddToCart(id, accId);
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("All", "Product");
        }

        public async Task<IActionResult> GetCart()
        {
            var accId = User.Claims.FirstOrDefault(a => a.Type == ClaimTypes.NameIdentifier)?.Value;

            var model = await cartService.GetCart(accId);

            return View("ShoppingCart", model);
        }

        public async Task<IActionResult> RemoveFromCart(int id)
        {
            var accId = User.Claims.FirstOrDefault(a => a.Type == ClaimTypes.NameIdentifier)?.Value;

            await cartService.RemoveFromCart(id, accId);

            return RedirectToAction(nameof(GetCart));
        }
    }
}
