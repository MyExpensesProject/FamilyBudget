using IdentityUser.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace FamilyBudget.Extensions;

public static class ServicesExtension
{
    public static void AddServices(WebApplicationBuilder webApplicationBuilder)
    {
        webApplicationBuilder.Services.AddScoped<UserManager<AppUserEntity>>();
        webApplicationBuilder.Services.AddMediatR(MediatRConfigurationExtension.Configuration());
    }
}