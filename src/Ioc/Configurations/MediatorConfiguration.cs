using Application.Contexts.Groups.Commands.CreateGroup;
using Microsoft.Extensions.DependencyInjection;

namespace Ioc.Configurations;

public static class MediatorConfiguration
{
    public static IServiceCollection AddMediator(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CreateGroupCommand>());

        return services;
    }
}