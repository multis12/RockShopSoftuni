using RockShop.Core.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace RockShop.Controllers
{
    [Authorize]
    public class GuitarController : Controller
    {
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = new GuitarQueryModel();

            return View(model);
        }

        
        public async Task<IActionResult> ShoppingCart()
        {
            var model = new GuitarQueryModel();

            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var model = new GuitarDetailsModel();

            return View(model);
        }

        
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Add(GuitarModel model)
        {
            int id = 1;

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = new GuitarModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, GuitarModel model)
        {
            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, GuitarModel model)
        {
            return RedirectToAction(nameof(All), new { id });
        }

    }
}
