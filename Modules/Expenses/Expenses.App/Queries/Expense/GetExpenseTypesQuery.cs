using AutoMapper;
using Expenses.Domain.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shared.Migrations;

namespace Expenses.App.Queries.Expense;

public record GetExpenseTypesQuery() : IRequest<List<ExpenseTypeDto>?>;

public class GetExpenseTypesQueryHandler : IRequestHandler<GetExpenseTypesQuery, List<ExpenseTypeDto>?>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetExpenseTypesQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<ExpenseTypeDto>?> Handle(GetExpenseTypesQuery query, CancellationToken cancellationToken)
    {
        var data = await _context.ExpenseTypes.ToListAsync(cancellationToken: cancellationToken);
        return _mapper.Map<List<ExpenseTypeDto>>(data);
    }
}