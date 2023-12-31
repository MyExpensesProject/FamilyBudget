using FamilyBudget.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Areas.User.Controllers;

/// <summary>
/// User controller
/// </summary>
[Area("User")]
[Authorize]
public class UserController : BaseController
{
    /// <summary>
    /// Index
    /// </summary>
    /// <returns></returns>
    public IActionResult Index()
    {
        return View();
    }
}