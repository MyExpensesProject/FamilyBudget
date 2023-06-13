using Expenses.Domain.Dto;
using Expenses.Domain.Entities;
using MediatR;
using Shared.Migrations;

namespace Expenses.App.Commands.Expense;

public record CreateExpenseTypeCommand(
    ExpenseTypeDto Dto
) : IRequest<ExpenseTypeEntity>;

public class CreateExpenseTypeCommandHandler : IRequestHandler<CreateExpenseTypeCommand, ExpenseTypeEntity>
{
    private readonly IApplicationDbContext _context;

    public CreateExpenseTypeCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ExpenseTypeEntity> Handle(CreateExpenseTypeCommand command, CancellationToken cancellationToken)
    {
        if (command.Dto is null)
            throw new Exception();

        var entity = new ExpenseTypeEntity
        {
            Id = Guid.NewGuid(),
            UserId = command.Dto.UserId,
            Name = command.Dto.Name,
            CreatedById = command.Dto.CreatedById,
            CreateDate = DateTime.Now,
            UpdateById = command.Dto.UpdateById,
            UpdateDate = DateTime.Now,
            IsDeleted = false
        };

        var result = await _context.ExpenseTypes.AddAsync(entity, cancellationToken);
        await _context.SaveChangesAsync();

        return result.Entity;
    }
}