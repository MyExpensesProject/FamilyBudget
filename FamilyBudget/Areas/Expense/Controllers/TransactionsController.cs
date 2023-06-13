using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Areas.Expense.Controllers;

/// <summary>
/// Transactions controller
/// </summary>
[Area("Expense")]
[Authorize]
public class TransactionsController : Controller
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