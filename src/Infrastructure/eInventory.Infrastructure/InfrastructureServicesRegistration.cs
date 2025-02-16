using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eInventory.Infrastructure;

public static class InfrastructureServicesRegistration
{
    public static IServiceCollection ConfigureInfrastructureService(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
