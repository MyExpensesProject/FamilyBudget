using FamilyBudget.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Areas.Budget.Controllers;

/// <summary>
/// Family controller
/// </summary>
[Area("Budget")]
[Authorize]
public class FamilyController : BaseController
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
    /// Family Budget
    /// </summary>
    /// <returns></returns>
    public IActionResult FamilyBudget()
    {
        return View();
    }

    /// <summary>
    /// Family Member Budget
    /// </summary>
    /// <returns></returns>
    public IActionResult FamilyMemberBudget()
    {
        return View();
    }

    /// <summary>
    /// Add user to family
    /// </summary>
    /// <returns></returns>
    public IActionResult AddUserToFamily()
    {
        return RedirectToAction("Index");
    }
    
    /// <summary>
    /// Remove user from family
    /// </summary>
    /// <returns></returns>
    public IActionResult RemoveUserFromFamily()
    {
        return RedirectToAction("Index");
    }
}