using FamilyBudget.Controllers.Base;
using MediatR;
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
    protected TransactionsController(IMediator mediator) : base(mediator)
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