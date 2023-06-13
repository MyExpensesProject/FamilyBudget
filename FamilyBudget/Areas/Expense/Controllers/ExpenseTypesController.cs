using System.Security.Claims;
using Expenses.App.Queries.Expense;
using FamilyBudget.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Infrastructure.Interfaces;

namespace FamilyBudget.Areas.Expense.Controllers;

/// <summary>
/// Expense types controller
/// </summary>
[Area("Expense")]
[Authorize]
public class ExpenseTypesController : BaseController
{
    private readonly IUserService<ClaimsPrincipal> _userService;
    
    protected ExpenseTypesController(IMediator mediator, IUserService<ClaimsPrincipal> userService) : base(mediator)
    {
        _userService = userService;
    }
    
    /// <summary>
    /// Index
    /// </summary>
    /// <returns></returns>
    public async Task<IActionResult> Index()
    {
        var data = await Mediator.Send(new GetExpenseTypesQuery());
        return View(data);
    }
}