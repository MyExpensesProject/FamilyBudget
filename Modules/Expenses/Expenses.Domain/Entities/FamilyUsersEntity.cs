using Shared.Core.Entities;

namespace Expenses.Domain.Entities;

/// <summary>
/// Family user entity
/// </summary>
public class FamilyUsersEntity : IBaseEntity
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Family head id
    /// </summary>
    public Guid FamilyHeadId { get; set; }
    
    /// <summary>
    /// Family member id
    /// </summary>
    public Guid FamilyMemberId { get; set; }
    
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