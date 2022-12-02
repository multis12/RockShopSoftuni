using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RockShop.Core.Contracts;
using RockShop.Core.Models.Guitar;
using RockShop.Core.Services;
using RockShop.Extensions;

namespace RockShop.Controllers
{
    [Authorize]
    public class GuitarController : Controller
    {

        private readonly IGuitarService guitarService;
        private readonly IStaffService staffService;

        public GuitarController(IGuitarService _guitarService
                               ,IStaffService _staffService)
        {
            guitarService = _guitarService;
            staffService = _staffService;
        }
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllGuitarsQueryModel query)
        {
            var result = await guitarService.All(
                query.Category,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllGuitarsQueryModel.GuitarsPerPage);

            query.TotalGuitarsCount = result.TotalGuitarsCount;
            query.Categories = await guitarService.AllCategoriesNames();
            query.Guitars = result.Guitars;

            return View(query);
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
        public async Task<IActionResult> Add()
        {
            if ((await staffService.ExistsById(User.Id())) == false)
            {
                return RedirectToAction(nameof(StaffController.Become), "Staff");
            }

            var model = new GuitarModel()
            {
                Categories = await guitarService.AllCategories(),
                Types = await guitarService.AllTypes()
            };



            return View(model);
        }

        
        [HttpPost]
        public async Task<IActionResult> Add(GuitarModel model)
        {
            if ((await staffService.ExistsById(User.Id())) == false)
            {
                return RedirectToAction(nameof(StaffController.Become), "Staff");
            }
            if ((await guitarService.CategoryExists(model.CategoryId)) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exists");
            }
            if ((await guitarService.TypeExists(model.TypeId)) == false)
            {
                ModelState.AddModelError(nameof(model.TypeId), "Type does not exists");
            }
            if (!ModelState.IsValid)
            {
                model.Categories = await guitarService.AllCategories();
                model.Types = await guitarService.AllTypes();

                return View(model);
            }

            int id = await guitarService.Create(model);

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
