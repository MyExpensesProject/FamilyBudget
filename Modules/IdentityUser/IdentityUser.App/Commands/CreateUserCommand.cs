﻿using IdentityUser.Domain.Dto;
using IdentityUser.Domain.Entities;
using MediatR;
using Shared.Migrations;

namespace IdentityUser.App.Commands;

/// <summary>
/// Command
/// </summary>
public class CreateUserCommand : IRequest<UserEntity>
{
    private SignUpDto Dto { get; }
        
    public CreateUserCommand(SignUpDto dto)
    {
        Dto = dto;
    }
    
    /// <summary>
    /// Handler
    /// </summary>
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserEntity>
    {
        private readonly IApplicationDbContext _context;
        
        public CreateUserCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<UserEntity> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            if (command.Dto is null)
                throw new Exception();
                
            var entity = new UserEntity
            {
                Id = default,
                    
                FullUserName = command.Dto.FullUserName,
                Password = command.Dto.Password,
                DateOfBirth = command.Dto.DateOfBirth,
                Email = command.Dto.Email,
                PhoneNumber = command.Dto.PhoneNumber,

                CreatedById = default,
                CreateDate = DateTime.Now,
                UpdateById = default,
                UpdateDate = DateTime.Now,
                IsDeleted = false
            };
            
            var result = await _context.Users.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync();
                
            return result.Entity;
        }
    }
}