using Microsoft.AspNetCore.Identity;

namespace IdentityUser.Domain.Entities;

/// <summary>
/// Role entity
/// </summary>
public class RoleEntity : IdentityRole<Guid>
{
    /// <summary>
    /// Role description
    /// </summary>
    public string? Description { get; set; }
}