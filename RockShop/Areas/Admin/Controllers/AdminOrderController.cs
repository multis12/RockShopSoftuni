using Microsoft.AspNetCore.Mvc;
using RockShop.Core.Contracts;
using RockShop.Core.Models.Order;

namespace RockShop.Areas.Admin.Controllers
{
    public class AdminOrderController : BaseController
    {
        private readonly IProductService productService;
        private readonly IStaffService staffService;
        private readonly IOrderService orderService;

        public AdminOrderController(IProductService _productService
                              , IStaffService _staffService
                              , IOrderService _orderService)
        {
            productService = _productService;
            staffService = _staffService;
            orderService = _orderService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await orderService.All();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> All(IEnumerable<OrderServiceModel> model)
        {
            return RedirectToAction("All", "AdminOrders");
        }
    }
}
