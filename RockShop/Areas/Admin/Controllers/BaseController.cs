using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static RockShop.Areas.Admin.Constants.AdminConstants;

namespace RockShop.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Route("Admin/[controller]/[Action]/{id?}")]
    [Authorize(Roles = AdminRoleName)]
    public class BaseController : Controller
    {
    }
}
