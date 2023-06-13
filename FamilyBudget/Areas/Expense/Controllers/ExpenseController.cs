using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Areas.Expense.Controllers;

/// <summary>
/// Expenses controller
/// </summary>
[Area("Expense")]
[Authorize]
public class ExpenseController : Controller
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