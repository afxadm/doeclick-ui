using Microsoft.Extensions.DependencyInjection;
using Totem.Domain.Interfaces.Apis;
using Totem.Integrations.Apis.Pagbank;

namespace Totem.IoC.Registers
{
    public static class ApiRegister
    {
        public static IServiceCollection RegisterApiPagbank(this IServiceCollection services)
        {
            services.AddScoped<IRequestPagbank, RequestPagbank>();

            return services;
        }
    }
}
