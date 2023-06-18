using Budget.App;
using Expenses.App;

namespace FamilyBudget.Extensions;

/// <summary>
/// MediatR configuration extension
/// </summary>
public static class MediatRConfigurationExtension
{
    /// <summary>
    /// Configuration application services
    /// </summary>
    /// <returns></returns>
    public static Action<MediatRServiceConfiguration> Configuration()
    {
        return cfg =>
        {
            cfg.RegisterServicesFromAssemblyContaining<BudgetApp>();
            cfg.RegisterServicesFromAssemblyContaining<ExpensesApp>();
        };
    }
}