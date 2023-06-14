using FamilyBudget.Controllers.Base;
using MediatR;
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
    protected ExpenseController(IMediator mediator) : base(mediator)
    {
    }
    
    /// <summary>
    /// Index
    /// </summary>
    /// <returns></returns>
    public IActionResult Index()
    {
        return View();
    }
}