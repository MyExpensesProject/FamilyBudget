using Shared.Core.Entities;

namespace Expenses.Domain.Entities;

/// <summary>
/// Expense entity
/// </summary>
public class ExpenseEntity : IBaseEntity
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    /// Transaction id
    /// </summary>
    public Guid TransactionId { get; set; }
    
    /// <summary>
    /// Transaction
    /// </summary>
    public TransactionEntity? Transaction { get; set; }
    
    /// <summary>
    /// Expense type id
    /// </summary>
    public Guid ExpenseTypeId { get; set; }
    
    /// <summary>
    /// Expense type
    /// </summary>
    public ExpenseTypeEntity? ExpenseType { get; set; }
    
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