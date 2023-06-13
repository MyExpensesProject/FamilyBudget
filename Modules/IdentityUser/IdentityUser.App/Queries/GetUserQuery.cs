﻿using IdentityUser.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shared.Migrations;

namespace IdentityUser.App.Queries
{
    /// <summary>
    /// Query
    /// </summary>
    public record GetUserQuery(string Email, string Password) : IRequest<UserEntity?>;

    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserEntity?>
    {
        private readonly IApplicationDbContext _context;

        public GetUserQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserEntity?> Handle(GetUserQuery query, CancellationToken cancellationToken)
        {
            var data = await _context.Users.FirstOrDefaultAsync(d =>
                    d.Email == query.Email
                    && d.Password == query.Password,
                cancellationToken: cancellationToken);

            return data;
        }
    }
}