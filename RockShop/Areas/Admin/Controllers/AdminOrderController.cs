using Microsoft.AspNetCore.Mvc;

namespace RockShop.Areas.Admin.Controllers
{
    public class AdminOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
