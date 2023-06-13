using Expenses.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shared.Migrations;

namespace Expenses.App.Queries.Expense;

public record GetExpenseTypesQuery() : IRequest<List<ExpenseTypeEntity>?>;

public class GetExpenseTypesQueryHandler : IRequestHandler<GetExpenseTypesQuery, List<ExpenseTypeEntity>?>
{
    private readonly IApplicationDbContext _context;

    public GetExpenseTypesQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<ExpenseTypeEntity>?> Handle(GetExpenseTypesQuery query, CancellationToken cancellationToken)
    {
        var data = await _context.ExpenseTypes.ToListAsync(cancellationToken: cancellationToken);
        return data;
    }
}