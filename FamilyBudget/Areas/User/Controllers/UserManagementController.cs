using FamilyBudget.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Areas.User.Controllers;

/// <summary>
/// User management controller
/// </summary>
[Area("User")]
[Authorize]
public class UserManagementController : BaseController
{
    /// <summary>
    /// Index
    /// </summary>
    /// <returns></returns>
    public IActionResult Index()
    {
        return View();
    }
    
    /// <summary>
    /// Roles
    /// </summary>
    /// <returns></returns>
    public IActionResult Roles()
    {
        return View();
    }
    
    /// <summary>
    /// Claims
    /// </summary>
    /// <returns></returns>
    public IActionResult Claims()
    {
        return View();
    }
    
    /// <summary>
    /// Users
    /// </summary>
    /// <returns></returns>
    public IActionResult Users()
    {
        return View();
    }
    
    /// <summary>
    /// Block List
    /// </summary>
    /// <returns></returns>
    public IActionResult BlockList()
    {
        return View();
    }
}