using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RockShop.Core.Contracts;
using RockShop.Core.Models.Order;
using System.Security.Claims;

namespace RockShop.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IProductService productService;
        private readonly IStaffService staffService;
        private readonly IOrderService orderService;

        public OrderController(IProductService _productService
                              ,IStaffService _staffService
                              ,IOrderService _orderService)
        {
            productService = _productService;
            staffService = _staffService;
            orderService = _orderService;
        }

        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            var model = new OrderViewModel();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Checkout(OrderViewModel model)
        {
            var accId = User.Claims.FirstOrDefault(a => a.Type == ClaimTypes.NameIdentifier)?.Value;
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await orderService.Checkout(accId, model);
            

            return RedirectToAction("All", "Product");
        }
    }
}
