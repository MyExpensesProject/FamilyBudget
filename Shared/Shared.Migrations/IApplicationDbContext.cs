using IdentityUser.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Shared.Migrations;

/// <summary>
/// Application db context interface
/// </summary>
public interface IApplicationDbContext
{
    /// <summary>
    /// Users
    /// </summary>
    public DbSet<UserEntity> Users { get; set; }
    
    /// <summary>
    /// User claims
    /// </summary>
    public DbSet<UserClaimEntity> UserClaims { get; set; }
    
    /// <summary>
    /// Roles
    /// </summary>
    public DbSet<RoleEntity> Roles { get; set; }
    
    /// <summary>
    /// User roles
    /// </summary>
    public DbSet<UserRolesEntity> UserRoles { get; set; }
    
    /// <summary>
    /// Save changes async
    /// </summary>
    /// <returns></returns>
    Task<int> SaveChangesAsync();
}