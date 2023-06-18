using FamilyBudget.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Areas.Expense.Controllers;

/// <summary>
/// Transactions controller
/// </summary>
[Area("Expense")]
[Authorize]
public class TransactionsController : BaseController
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
    /// User transactions
    /// </summary>
    /// <returns></returns>
    public IActionResult UserTransactions()
    {
        return View();
    }

    /// <summary>
    /// Create transaction
    /// </summary>
    /// <returns></returns>
    public IActionResult CreateTransaction()
    {
        return View();
    }
}