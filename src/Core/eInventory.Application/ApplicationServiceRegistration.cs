using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace eInventory.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection ConfigureApplicationService(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(m => m.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }
}
