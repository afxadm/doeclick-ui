using Microsoft.Extensions.DependencyInjection;
using Totem.Application.UseCases;

namespace Totem.IoC.Registers
{
    public static class UseCasesRegisters
    {
        public static IServiceCollection RegisterUseCases(this IServiceCollection service)
        {
            service.AddScoped<IAuthenticationUseCase, AuthenticationUseCase>();
            service.AddScoped<IBranchUseCase, BranchUseCase>();
            service.AddScoped<ICategoryUseCase, CategoryUseCase>();
            service.AddScoped<ICauseUseCase, CauseUseCase>();
            service.AddScoped<IOperationUseCase, OperationUseCase>();
            service.AddScoped<IPaymentUseCase, PaymentUseCase>();
            service.AddScoped<IPositionUseCase, PositionUseCase>();
            service.AddScoped<ITaxpayerUseCase, TaxpayerUseCase>();
            service.AddScoped<IUserUseCase, UserUseCase>();

            return service;
        }
    }
}
