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
    /// Id created user
    /// </summary>
    public Guid CreatedById { get; set; }

    /// <summary>
    /// Created date
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// Id updated user
    /// </summary>
    public Guid UpdateById { get; set; }

    /// <summary>
    /// Update date
    /// </summary>
    public DateTime UpdateDate { get; set; }

    /// <summary>
    /// Is deleted flag
    /// </summary>
    public bool IsDeleted { get; set; }
}