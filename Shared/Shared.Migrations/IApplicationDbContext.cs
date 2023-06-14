using Expenses.Domain.Entities;
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
    public DbSet<AppUserEntity> Users { get; set; }

    /// <summary>
    /// User roles
    /// </summary>
    public DbSet<AppUserRoleEntity> UserRoles { get; set; }

    /// <summary>
    /// User claims
    /// </summary>
    public DbSet<AppUserClaimEntity> UserClaims { get; set; }

    /// <summary>
    /// User logins
    /// </summary>
    public DbSet<AppUserLoginEntity> UserLogins { get; set; }

    /// <summary>
    /// User tokens
    /// </summary>
    public DbSet<AppUserTokenEntity> UserTokens { get; set; }

    /// <summary>
    /// Roles
    /// </summary>
    public DbSet<AppRoleEntity> Roles { get; set; }

    /// <summary>
    /// Role claims
    /// </summary>
    public DbSet<AppRoleClaimEntity> RoleClaims { get; set; }
    
    /// <summary>
    /// Expenses
    /// </summary>
    public DbSet<ExpenseEntity> Expenses { get; set; }
    
    /// <summary>
    /// Family users
    /// </summary>
    public DbSet<FamilyUsersEntity> FamilyUsers { get; set; }
    
    /// <summary>
    /// Expense types
    /// </summary>
    public DbSet<ExpenseTypeEntity> ExpenseTypes { get; set; }
    
    /// <summary>
    /// Transactions
    /// </summary>
    public DbSet<TransactionEntity> Transactions { get; set; }

    /// <summary>
    /// Save changes async
    /// </summary>
    /// <returns></returns>
    Task<int> SaveChangesAsync();
}