using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Areas.Expense.Controllers;

/// <summary>
/// Expense types controller
/// </summary>
[Area("Expense")]
[Authorize]
public class ExpenseTypesController : Controller
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