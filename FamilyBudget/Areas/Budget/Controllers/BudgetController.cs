using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Areas.Budget.Controllers;

/// <summary>
/// Budget controller
/// </summary>
[Area("Budget")]
[Authorize]
public class BudgetController : Controller
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