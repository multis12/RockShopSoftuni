using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RockShop.Core.Constants;
using RockShop.Core.Contracts;
using RockShop.Core.Models.Staff;
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
            var model = new BecomeStaffModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeStaffModel model)
        {
            var userId = User.Id();
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await staffService.ExistsById(userId))
            {
                TempData[MessageConstants.ErrorMessage] = "You are already a part of our staff";

                return RedirectToAction("Index", "Home");
            }
            if (await staffService.UserWithPhoneNumberExists(model.PhoneNumber))
            {
                TempData[MessageConstants.ErrorMessage] = "Phone number already exists";
            }

            await staffService.Create(userId, model.PhoneNumber);
            return RedirectToAction("All", "Guitar"); 
        }
    }
}
