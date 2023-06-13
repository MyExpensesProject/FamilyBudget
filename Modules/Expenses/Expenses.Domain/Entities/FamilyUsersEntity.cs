using Shared.Core.Entities;

namespace Expenses.Domain.Entities;

/// <summary>
/// Family entity
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