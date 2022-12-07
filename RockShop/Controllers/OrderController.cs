using Microsoft.AspNetCore.Mvc;

namespace RockShop.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
