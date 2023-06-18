using FamilyBudget.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Areas.Budget.Controllers;

/// <summary>
/// Budget controller
/// </summary>
[Area("Budget")]
[Authorize]
public class BudgetController : BaseController
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
    /// Expense types
    /// </summary>
    /// <returns></returns>
    public IActionResult ExpenseTypes()
    {
        return View();
    }

    /// <summary>
    /// User budget
    /// </summary>
    /// <returns></returns>
    public IActionResult FamilyBudget()
    {
        return View();
    }

    /// <summary>
    /// User budget
    /// </summary>
    /// <returns></returns>
    public IActionResult FamilyMemberBudget()
    {
        return View();
    }
}