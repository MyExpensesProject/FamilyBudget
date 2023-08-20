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