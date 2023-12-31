using FamilyBudget.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Areas.Expense.Controllers;

/// <summary>
/// Expenses controller
/// </summary>
[Area("Expense")]
[Authorize]
public class ExpenseController : BaseController
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
    /// User expenses
    /// </summary>
    /// <returns></returns>
    public IActionResult UserExpenses()
    {
        return View();
    }

    /// <summary>
    /// Create expense
    /// </summary>
    /// <returns></returns>
    public IActionResult CreateExpense()
    {
        return RedirectToAction("Index");
    }
    
    /// <summary>
    /// Update expense
    /// </summary>
    /// <returns></returns>
    public IActionResult UpdateExpense()
    {
        return RedirectToAction("Index");
    }
    
    /// <summary>
    /// Delete expense
    /// </summary>
    /// <returns></returns>
    public IActionResult DeleteExpense()
    {
        return RedirectToAction("Index");
    }
}