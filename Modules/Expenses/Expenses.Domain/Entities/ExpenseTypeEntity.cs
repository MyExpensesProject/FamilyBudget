using System.Collections.ObjectModel;
using Shared.Core.Entities;

namespace Expenses.Domain.Entities;

/// <summary>
/// Expense type
/// </summary>
public class ExpenseTypeEntity : IBaseEntity
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// User id
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    /// Expenses
    /// </summary>
    public Collection<ExpenseEntity>? Expenses { get; set; }

    /// <summary>
    /// Создал
    /// </summary>
    public Guid CreatedById { get; set; }

    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// Обновил
    /// </summary>
    public Guid UpdateById { get; set; }

    /// <summary>
    /// Дата обновления
    /// </summary>
    public DateTime UpdateDate { get; set; }

    /// <summary>
    /// Флаг удаления true - удален, false - не удален
    /// </summary>
    public bool IsDeleted { get; set; }
}