using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Repository.Context;

namespace Ioc.Configurations;

public static class DatabaseConfiguration
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            var connection = configuration.GetConnectionString("Application");
            var version = new MySqlServerVersion(new Version(8, 4, 0));
            
            options.UseMySql(connection, version)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        });

        return services;
    }
}