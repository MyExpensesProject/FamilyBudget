using FamilyBudget.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Areas.User.Controllers;

/// <summary>
/// User controller
/// </summary>
[Area("User")]
[Authorize]
public class UserController : BaseController
{
    protected UserController(IMediator mediator) : base(mediator)
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