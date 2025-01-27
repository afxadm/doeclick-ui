using Microsoft.Extensions.DependencyInjection;
using Totem.Domain.Interfaces;
using Totem.Infrastructure.Repositories;

namespace Totem.IoC.Registers
{
    public static class RepositoryRegister
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBranchRepository, BranchRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICauseRepository, CauseRepository>();
            services.AddScoped<IOperationRepository, OperationRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<ITaxpayerRepository, TaxpayerRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        } 
    }
}
