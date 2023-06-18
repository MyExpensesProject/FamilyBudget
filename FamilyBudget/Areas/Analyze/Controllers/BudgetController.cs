using FamilyBudget.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Areas.Analyze.Controllers;

/// <summary>
/// Analyze controller
/// </summary>
[Area("Analyze")]
[Authorize]
public class AnalyzeController : BaseController
{
    /// <summary>
    /// Index
    /// </summary>
    /// <returns></returns>
    public IActionResult Index()
    {
        return View();
    }
}