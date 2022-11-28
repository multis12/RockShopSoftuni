using Microsoft.AspNetCore.Mvc;
using RockShop.Core.Contracts;
using RockShop.Models;
using System.Diagnostics;

namespace RockShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGuitarService guitarService;

        public HomeController(IGuitarService _guitarService)
        {
            guitarService = _guitarService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await guitarService.LastSevenGuitars();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}