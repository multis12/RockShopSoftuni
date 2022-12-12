using Microsoft.AspNetCore.Mvc;
using RockShop.Core.Contracts;
using RockShop.Core.Models.Order;
using RockShop.Core.Models.Product;
using static RockShop.Areas.Admin.Constants.AdminConstants;

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

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if ((await orderService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }
            if (!User.IsInRole(AdminRoleName))
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            var model = await orderService.OrderDetailsById(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, OrderViewModel model)
        {
            if ((await orderService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }
            if (!User.IsInRole(AdminRoleName))
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            await orderService.Delete(id);

            return RedirectToAction(nameof(All));
        }
    }
}
