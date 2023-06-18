using System.Diagnostics;
using System.Security.Claims;
using FamilyBudget.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Infrastructure.Interfaces;

namespace FamilyBudget.Controllers.Base;

/// <summary>
/// Base controller
/// </summary>
public class BaseController : Controller
{
    /// <summary>
    /// Mediator
    /// </summary>
    protected IMediator Mediator =>
        HttpContext.RequestServices.GetService<IMediator>()
        ?? throw new InvalidOperationException();

    /// <summary>
    /// User service
    /// </summary>
    protected IUserService<ClaimsPrincipal> UserService =>
        HttpContext.RequestServices.GetService<IUserService<ClaimsPrincipal>>()
        ?? throw new InvalidOperationException();

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