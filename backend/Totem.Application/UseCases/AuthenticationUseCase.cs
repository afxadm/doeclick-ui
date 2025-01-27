using Microsoft.Extensions.Configuration;
using Serilog;
using Totem.Domain;
using Totem.Domain.Dtos;
using Totem.Domain.Interfaces.Facades;
using Totem.Domain.Util;


namespace Totem.Application.UseCases
{
    public class AuthenticationUseCase : IAuthenticationUseCase
    {
        private readonly IUserFacade _userFacade;
        private readonly IBranchFacade _branchFacade;
        private readonly IPositionFacade _positionFacade;
        private readonly ILogger _logger;
        private readonly JwtTokenHelper _jwtHelper;

        public AuthenticationUseCase(IUserFacade userFacade,
            IBranchFacade branchFacade, IPositionFacade positionFacade,
            IConfiguration configuration, ILogger logger)
        {
            _userFacade = userFacade;
            _branchFacade = branchFacade;
            _positionFacade = positionFacade;
            _jwtHelper = new JwtTokenHelper(configuration);
            _logger = logger;
        }

        public async Task<ResponseBase<object>> Login(AuthenticationDto authDto)
        {
            var user = await _userFacade.GetUserByCpf(authDto.Cpf);

            if (user == null)
                return new ResponseBase<object> { IsSuccess = false, Data = "Usuário não encontrado." };

            if (!PasswordHelper.ValidatePassword(authDto.Password, user.Password))
                return new ResponseBase<object> { IsSuccess = false, Data = "Senha inválida." };

            if (user.BranchId.HasValue)
                user.Branch = await _branchFacade.GetBranchById(user.BranchId.Value);

            if (user.PositionId.HasValue)
                user.Position = await _positionFacade.GetPositionById(user.PositionId.Value);

            var tokenString = _jwtHelper.GenerateToken(user.Name, user.TypeUser.ToString());

            _logger.Information(
                "Login is success. Entity: {Entity}, EntityId: {EntityId}, Action: {Action}, CreatedAt: {CreatedAt}, Status: {Status}",
                user.GetType().Name, // Entity
                user.Id,             // EntityId
                "POST.LOGIN",        // Action
                DateTime.UtcNow,     // CreatedAt
                "SUCCESS"            // Status
            );

            return new ResponseBase<object>()
            {
                IsSuccess = true,
                Data = UserResponseDto.Of(user, tokenString)
            };
        }
    }
}
