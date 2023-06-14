using Shared.Core.Entities;

namespace Expenses.Domain.Entities;

/// <summary>
/// Transaction entity
/// </summary>
public class TransactionEntity : IBaseEntity
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// User from id
    /// </summary>
    public Guid UserFromId { get; set; }
    
    /// <summary>
    /// User to id
    /// </summary>
    public Guid UserToId { get; set; }
    
    /// <summary>
    /// Amount
    /// </summary>
    public double Amount { get; set; }
    
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