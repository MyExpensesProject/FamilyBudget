using System.Diagnostics;
using FamilyBudget.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Controllers.Base;

/// <summary>
/// Base controller
/// </summary>
public class BaseController : Controller
{
    protected readonly IMediator Mediator;

    protected BaseController(IMediator mediator)
    {
        Mediator = mediator;
    }
    
    /// <summary>
    /// Error page
    /// </summary>
    /// <returns></returns>
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}