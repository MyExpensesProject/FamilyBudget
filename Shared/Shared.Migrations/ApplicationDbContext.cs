﻿using IdentityUser.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shared.Migrations.Relationships;

#pragma warning disable CS8618
#pragma warning disable CS0108, CS0114

namespace Shared.Migrations;

/// <summary>
/// Application db context
/// </summary>
public class ApplicationDbContext : IdentityDbContext<UserEntity, RoleEntity, Guid>, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

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
    /// <param name="modelBuilder"> Model builder </param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        RenameIdentityTables(modelBuilder);
        ConfigureRelationship.ConfigureRelationships(modelBuilder);
    }

    /// <summary>
    /// Save changes async
    /// </summary>
    /// <returns> Changed entities number </returns>
    public async Task<int> SaveChangesAsync()
    {
        return await base.SaveChangesAsync();
    }

    /// <summary>
    /// Rename default identity tables to custom names
    /// </summary>
    /// <param name="modelBuilder"> Model builder </param>
    private void RenameIdentityTables(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.HasDefaultSchema("public");
        
        modelBuilder.Entity<UserEntity>(entity =>
        {
            entity.ToTable(name: "Users");
        });
        
        modelBuilder.Entity<RoleEntity>(entity =>
        {
            entity.ToTable(name: "Roles");
        });
        
        modelBuilder.Entity<UserRolesEntity>(entity =>
        {
            entity.ToTable("UserRoles");
        });
        
        modelBuilder.Entity<UserClaimEntity>(entity =>
        {
            entity.ToTable("UserClaims");
        });
        
        modelBuilder.Entity<IdentityUserLogin<Guid>>(entity =>
        {
            entity.ToTable("UserLogins");
        });
        
        modelBuilder.Entity<IdentityRoleClaim<Guid>>(entity =>
        {
            entity.ToTable("RoleClaims");
        });
        
        modelBuilder.Entity<IdentityUserToken<Guid>>(entity =>
        {
            entity.ToTable("UserTokens");
        });
    }
}