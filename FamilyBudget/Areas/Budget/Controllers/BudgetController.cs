using FamilyBudget.Controllers.Base;
using MediatR;
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
    protected BudgetController(IMediator mediator) : base(mediator)
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