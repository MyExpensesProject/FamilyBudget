using FamilyBudget.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace FamilyBudget.Controllers;

public class HomeController : BaseController
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, IMediator mediator) : base(mediator)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}