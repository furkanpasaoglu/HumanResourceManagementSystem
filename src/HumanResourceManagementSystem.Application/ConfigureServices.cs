using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace HumanResourceManagementSystem.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(x=>x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }
}