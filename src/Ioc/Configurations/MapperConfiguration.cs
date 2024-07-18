using Mapster;
using Microsoft.Extensions.DependencyInjection;

namespace Ioc.Configurations;

public static class MapperConfiguration
{
    public static IServiceCollection AddMapper(this IServiceCollection services)
    {
        services.AddMapster();

        return services;
    }
}