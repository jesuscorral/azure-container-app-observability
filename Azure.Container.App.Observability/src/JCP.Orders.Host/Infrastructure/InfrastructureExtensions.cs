using JCP.Orders.Host.Diagnostics;

namespace JCP.Orders.Host.Infrastructure
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddSingleton<HostDiagnostics>();
            return services;    
        }
    }
}
