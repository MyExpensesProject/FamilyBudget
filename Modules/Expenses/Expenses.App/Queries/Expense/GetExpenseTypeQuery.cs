using Expenses.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shared.Migrations;

namespace Expenses.App.Queries.Expense;

public record GetExpenseTypeQuery(Guid Id) : IRequest<ExpenseTypeEntity?>;

public class GetExpenseTypeQueryHandler : IRequestHandler<GetExpenseTypeQuery, ExpenseTypeEntity?>
{
    private readonly IApplicationDbContext _context;

    public GetExpenseTypeQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ExpenseTypeEntity?> Handle(GetExpenseTypeQuery query, CancellationToken cancellationToken)
    {
        var data = await _context.ExpenseTypes.FirstOrDefaultAsync(d =>
                d.Id == query.Id,
            cancellationToken: cancellationToken);

        return data;
    }
}