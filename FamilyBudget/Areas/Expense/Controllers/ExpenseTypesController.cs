using Expenses.App.Queries.Expense;
using FamilyBudget.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Areas.Expense.Controllers;

/// <summary>
/// Expense types controller
/// </summary>
[Area("Expense")]
[Authorize]
public class ExpenseTypesController : BaseController
{
    /// <summary>
    /// Index
    /// </summary>
    /// <returns></returns>
    public async Task<IActionResult> Index()
    {
        var data = await Mediator.Send(new GetExpenseTypesQuery());
        return View(data);
    }

    /// <summary>
    /// Create expense type
    /// </summary>
    /// <returns></returns>
    public IActionResult CreateExpenseType()
    {
        return RedirectToAction("Index");
    }

    /// <summary>
    /// Update expense type
    /// </summary>
    /// <returns></returns>
    public IActionResult UpdateExpenseType()
    {
        return RedirectToAction("Index");
    }

    /// <summary>
    /// Get expense type
    /// </summary>
    /// <returns></returns>
    public IActionResult GetExpenseTypeById()
    {
        return RedirectToAction("Index");
    }
    
    /// <summary>
    /// Delete expense type
    /// </summary>
    /// <returns></returns>
    public IActionResult DeleteExpenseType()
    {
        return RedirectToAction("Index");
    }
}