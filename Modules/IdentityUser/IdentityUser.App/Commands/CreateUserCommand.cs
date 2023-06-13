using IdentityUser.Domain.Dto;
using IdentityUser.Domain.Entities;
using MediatR;
using Shared.Migrations;

namespace IdentityUser.App.Commands;

/// <summary>
/// Command
/// </summary>
public class CreateUserCommand : IRequest<AppUserEntity>
{
    private SignUpDto Dto { get; }
        
    public CreateUserCommand(SignUpDto dto)
    {
        Dto = dto;
    }
    
    /// <summary>
    /// Handler
    /// </summary>
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, AppUserEntity>
    {
        private readonly IApplicationDbContext _context;
        
        public CreateUserCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<AppUserEntity> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            if (command.Dto is null)
                throw new Exception();
                
            var entity = new AppUserEntity
            {
                Id = default,
                Email = command.Dto.Email,
                PhoneNumber = command.Dto.PhoneNumber,
            };
            
            var result = await _context.Users.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync();
                
            return result.Entity;
        }
    }
}