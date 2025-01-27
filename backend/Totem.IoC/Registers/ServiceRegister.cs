using Microsoft.Extensions.DependencyInjection;
using Totem.Domain.Facades;
using Totem.Domain.Interfaces;
using Totem.Domain.Interfaces.Facades;

namespace Totem.IoC.Registers
{
    public static class ServiceRegister
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IBranchFacade, BranchFacade>();
            services.AddScoped<ICauseFacade, CauseFacade>();
            services.AddScoped<ICategoryFacade, CategoryFacade>();
            services.AddScoped<IOperationFacade, OperationFacade>();
            services.AddScoped<IPositionFacade, PositionFacade>();
            services.AddScoped<ITaxpayerFacade, TaxpayerFacade>();
            services.AddScoped<IUserFacade, UserFacade>();
            
            return services;
        }
    }
}
