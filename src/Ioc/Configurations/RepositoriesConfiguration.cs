using Application.Contexts.Groups.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Repository.Repositories.Groups;

namespace Ioc.Configurations;

public static class RepositoriesConfiguration
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IGroupsRepository, GroupsRepository>();

        return services;
    }
}