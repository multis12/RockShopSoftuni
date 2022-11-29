using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RockShop.Core.Constants;
using RockShop.Core.Contracts;
using RockShop.Core.Models.Admin;
using RockShop.Extensions;

namespace RockShop.Controllers
{
    [Authorize]
    public class StaffController : Controller
    {
        private readonly IStaffService staffService;

        public StaffController(IStaffService _staffService)
        {
            staffService = _staffService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            if (await staffService.ExistsById(User.Id()))
            {
                TempData[MessageConstants.ErrorMessage] = "Вие вече сте служител";

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeStaffModel model)
        {
            return RedirectToAction("All", "Product"); 
        }
    }
}
